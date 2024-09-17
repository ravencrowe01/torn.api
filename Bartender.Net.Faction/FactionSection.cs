﻿using Bartender.Net.Faction.Applications;
using Bartender.Net.Faction.Armor;
using Bartender.Net.Faction.ArmoryNews;
using Bartender.Net.Faction.AttackNews;
using Bartender.Net.Faction.Attacks;
using Bartender.Net.Faction.AttacksFull;
using Bartender.Net.Faction.Basic;
using Bartender.Net.Faction.Boosters;
using Bartender.Net.Faction.Caches;
using Bartender.Net.Faction.Chain;
using Bartender.Net.Faction.ChainReport;
using Bartender.Net.Faction.Contributors;
using Bartender.Net.Faction.CrimeExp;
using Bartender.Net.Faction.CrimeNews;
using Bartender.Net.Faction.Crimes;
using Bartender.Net.Faction.Currency;
using Bartender.Net.Faction.Donations;
using Bartender.Net.Faction.Drugs;
using Bartender.Net.Faction.FundsNews;
using Bartender.Net.Faction.MainNews;
using Bartender.Net.Faction.Medical;
using Bartender.Net.Faction.MembershipNews;
using Bartender.Net.Faction.Positions;
using Bartender.Net.Faction.RankedWars;
using Bartender.Net.Faction.Stats;
using Bartender.Net.Faction.Temporary;
using Bartender.Net.Faction.Territory;
using Bartender.Net.Faction.TerritoryNews;
using Bartender.Net.Faction.Upgrades;
using Bartender.Net.Faction.Weapons;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Faction;
public class FactionSection : ISectiony {
    public int ID => 3;

    public string Name => "faction";

    public static readonly Selection Applications = new ("applications", AccessLevel.Limited, typeof (ApplicationsRoot));
    public static readonly Selection Armor = new ("armor", AccessLevel.Minimal, typeof (ArmorRoot));
    public static readonly Selection ArmoryNews = new ("armorynews", AccessLevel.Minimal, typeof (ArmoryNewsRoot));
    public static readonly Selection AttackNews = new ("attacknews", AccessLevel.Limited, typeof (AttackNewsRoot));
    public static readonly Selection Attacks = new ("attacks", AccessLevel.Limited, typeof (FactionAttacksRoot));
    public static readonly Selection AttacksFull = new ("attacksfull", AccessLevel.Limited, typeof (FactionAttacksFullRoot));
    public static readonly Selection Basic = new ("basic", AccessLevel.Public, typeof (FactionBasic));
    public static readonly Selection Boosters = new ("boosters", AccessLevel.Minimal, typeof (BoostersRoot));
    public static readonly Selection Caches = new ("caches", AccessLevel.Limited, typeof (CachesRoot));
    //public static readonly Selection Cesium = new ("cesium", AccessLevel.Limited, typeof(CesiumRoot));
    public static readonly Selection Chain = new ("chain", AccessLevel.Public, typeof (ChainRoot));
    public static readonly Selection ChainReport = new ("chainreport", AccessLevel.Public, typeof (ChainReportRoot));
    public static readonly Selection Chains = new ("chains", AccessLevel.Minimal, typeof (ChainRoot));
    public static readonly Selection Contributors = new ("contributors", AccessLevel.Limited, typeof (ContributorsRoot));
    public static readonly Selection CrimeExp = new ("crimeexp", AccessLevel.Minimal, typeof (CrimeExpRoot));
    public static readonly Selection CrimeNews = new ("crimenews", AccessLevel.Minimal, typeof (CrimeNewsRoot));
    public static readonly Selection Crimes = new ("crimes", AccessLevel.Minimal, typeof (FactionCrimesRoot));
    public static readonly Selection Currency = new ("currency", AccessLevel.Limited, typeof (CurrencyRoot));
    public static readonly Selection Donations = new ("donations", AccessLevel.Limited, typeof (DonationsRoot));
    public static readonly Selection Drugs = new ("drugs", AccessLevel.Minimal, typeof (DrugsRoot));
    public static readonly Selection FundsNews = new ("fundsnews", AccessLevel.Limited, typeof (FundsNewsRoot));
    public static readonly Selection MainNews = new ("mainnews", AccessLevel.Minimal, typeof (MainNewsRoot));
    public static readonly Selection Medical = new ("medical", AccessLevel.Minimal, typeof (MedicalRoot));
    public static readonly Selection MembershipNews = new ("membershipnews", AccessLevel.Minimal, typeof (MembershipNewsRoot));
    public static readonly Selection Positions = new ("positions", AccessLevel.Minimal, typeof (PositionsRoot));
    public static readonly Selection RankedWars = new ("rankedwars", AccessLevel.Public, typeof (RankedWarsRoot));
    //public static readonly Selection Reports = new ("reports", AccessLevel.Limited, typeof(ReportsRoot));
    //public static readonly Selection Revives = new ("revives", AccessLevel.Minimal, typeof(RevivesRoot));
    //public static readonly Selection RevivesFull = new ("revivesfull", AccessLevel.Minimal, typeof(RevivesFullRoot));
    public static readonly Selection Stats = new ("stats", AccessLevel.Minimal, typeof (StatsRoot));
    public static readonly Selection Temporary = new ("temporary", AccessLevel.Minimal, typeof (TemporaryRoot));
    public static readonly Selection Territory = new ("territory", AccessLevel.Public, typeof (TerritoryRoot));
    public static readonly Selection TerritoryNews = new ("territorynews", AccessLevel.Minimal, typeof (TerritoryNewsRoot));
    public static readonly Selection Upgrades = new ("upgrades", AccessLevel.Minimal, typeof (UpgradesRoot));
    public static readonly Selection Weapons = new ("weapons", AccessLevel.Minimal, typeof (WeaponsRoot));

    public IEnumerable<Selection> Selections {
        get {
            yield return Applications;
            yield return Armor;
            yield return ArmoryNews;
            yield return AttackNews;
            yield return Attacks;
            yield return AttacksFull;
            yield return Basic;
            yield return Boosters;
            yield return Caches;
            //yield return Cesium;
            yield return Chain;
            yield return ChainReport;
            yield return Chains;
            yield return Contributors;
            yield return CrimeExp;
            yield return CrimeNews;
            yield return Crimes;
            yield return Currency;
            yield return Donations;
            yield return Drugs;
            yield return FundsNews;
            yield return MainNews;
            yield return Medical;
            yield return MembershipNews;
            yield return Positions;
            yield return RankedWars;
            //yield return Reports;
            //yield return Revives;
            //yield return RevivesFull;
            yield return Stats;
            yield return Temporary;
            yield return Territory;
            yield return TerritoryNews;
            yield return Upgrades;
            yield return Weapons;
        }
    }
}
