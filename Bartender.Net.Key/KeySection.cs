﻿using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Key;

public class KeySection : Section {
    private static KeySection _instance = default!;

    private readonly static object _lock = new ();

    public static KeySection Instance {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new KeySection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection KeyInfo;

    public override IEnumerable<Selection> Selections {
        get {
            yield return KeyInfo;
        }
    }

    private KeySection () : base ("key") {
        KeyInfo = new (this, "info", AccessLevel.Public, typeof (KeyInfo), typeof (KeyInfo));
    }
}
