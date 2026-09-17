// Structure only. Read corresponding native-evidence .asm for real implementation.
// Namespace: HotFix.BattleLogic
internal class CharacterComponentOnHit : CharacterComponentBase // TypeDefIndex: 10963
{
	// Fields
	private FP _hitTime; // 0x40
	private FP _lastLaserHitTime; // 0x48
	private readonly Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, CharacterComponentOnHit.WeaponHittedCountData> _weaponHittedCountDict; // 0x50
	private readonly Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, CharacterComponentOnHit.WeaponHittedCountData> _weaponHittedCountDict1s; // 0x58
	private readonly Dictionary<ValueTuple<EntityRef, int>, CharacterComponentOnHit.WeaponHittedCountData> _weaponIdHittedCountDict; // 0x60
	private readonly Dictionary<ValueTuple<EntityRef, int>, CharacterComponentOnHit.WeaponHittedCountData> _weaponIdHittedCountDict1s; // 0x68
	private readonly HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>> _sameEnemyHurtClearedWeaponTypes; // 0x70
	private readonly HashSet<ValueTuple<EntityRef, EntityCharacterTypeKey>> _sameEnemyHurtClearedWeaponTypes1s; // 0x78
	public static readonly FP WeaponHittedCountResetInterval; // 0x0
	public static readonly FP WeaponHittedCountResetInterval1s; // 0x8
	private FP _lastHurtTimestamp; // 0x80
	private FP _elapsedSinceLastHurt; // 0x88
	private FP _lastNotifiedHurtElapsed; // 0x90
	[CompilerGenerated]
	private Action<FP> OnHurtElapsedTimeChanged; // 0x98
	private int _dyingHp; // 0xA0

	// Properties
	public FP LastHurtTimestamp { get; }
	public FP ElapsedSinceLastHurt { get; }

	// Methods

	// RVA: 0x66B6858 Offset: 0x66B2858 VA: 0x66B6858
	private void OnHitByBullet(BulletHurtInfo hurtInfo) { }

	// RVA: 0x66B6E54 Offset: 0x66B2E54 VA: 0x66B6E54
	private bool TryInterceptHeroBoundBulletByWingPlaneResist(EntityBullet bullet) { }

	// RVA: 0x66B8228 Offset: 0x66B4228 VA: 0x66B8228
	private void HandleBeforeHurtTarget(EntityCharacter triggerEntity, HurtDataArray hurtDataArray) { }

	// RVA: 0x66B7BC4 Offset: 0x66B3BC4 VA: 0x66B7BC4
	private HurtSourceData CreateBulletHurtSourceData(BulletHurtInfo hurtInfo, BulletFlag bulletFlag, BulletOwnerInfo ownerInfo, AttackSourceInfo attackInfo) { }

	// RVA: 0x66B7EDC Offset: 0x66B3EDC VA: 0x66B7EDC
	private HurtDataArray BuildBulletHurtDataArray(BulletHurtInfo hurtInfo, HurtSourceData sourceData, AttackSourceInfo attackInfo) { }

	// RVA: 0x66B8EAC Offset: 0x66B4EAC VA: 0x66B8EAC
	private FP CalcBulletGrowthHurt(EntityRef ownerInstanceId, int bulletId) { }

	// RVA: 0x66B7FB8 Offset: 0x66B3FB8 VA: 0x66B7FB8
	private void HandleLaserStacking(BulletType bulletType, EntityCharacter ownerEntity) { }

	// RVA: 0x66B7A34 Offset: 0x66B3A34 VA: 0x66B7A34
	private void HandleOwnerAndTriggerOnBulletHit(BulletHurtInfo hurtInfo, EntityBullet bullet, BulletData bulletData, BulletFlag bulletFlag, EntityRef triggerInstanceId, EntityCharacter triggerEntity, EntityCharacter ownerEntity) { }

	// RVA: 0x66B97B4 Offset: 0x66B57B4 VA: 0x66B97B4
	private void HandleOwnerHitCountsAndAnyWeaponEvents(BulletHurtInfo hurtInfo, BulletData bulletData, EntityRef triggerInstanceId, EntityCharacter triggerEntity, EntityCharacter ownerEntity, EntityBullet bullet) { }

	// RVA: 0x66BBAD0 Offset: 0x66B7AD0 VA: 0x66BBAD0
	private bool IsSameEnemyMilestoneExplosionHit(EntityCharacter ownerEntity, EntityCharacterTypeKey hittedKey, int weaponId, EntityBullet bullet) { }

	// RVA: 0x66BC4C8 Offset: 0x66B84C8 VA: 0x66BC4C8
	private void TryFireSameEnemyMilestoneExplosion(EntityCharacter ownerEntity, EntityRef rootOwnerInstanceId, EntityCharacterTypeKey hittedKey, FPVector3 hitPoint, int hitCountHalfSecond, int hitCountOneSecond) { }

	// RVA: 0x66BA928 Offset: 0x66B6928 VA: 0x66BA928
	private void HandleGenericHitTrigger(BulletHurtInfo hurtInfo, EntityBullet bullet, BulletData bulletData, BulletFlag bulletFlag, EntityRef triggerInstanceId, EntityCharacter ownerEntity) { }

	// RVA: 0x66BB1A4 Offset: 0x66B71A4 VA: 0x66BB1A4
	private void HandleBatterLogic(BulletHurtInfo hurtInfo, EntityRef triggerInstanceId, EntityCharacter triggerEntity) { }

	// RVA: 0x66BB5E0 Offset: 0x66B75E0 VA: 0x66BB5E0
	private void HandleHitHealIfHero(BulletHurtInfo hurtInfo, EntityBullet bullet, EntityCharacter triggerEntity) { }

	// RVA: 0x66B862C Offset: 0x66B462C VA: 0x66B862C
	private void ApplyBulletDamageAndEffects(BulletHurtInfo hurtInfo, EntityBullet bullet, BulletData bulletData, BulletFlag bulletFlag, HurtSourceData sourceData, HurtDataArray hurtDataArray, EntityRef triggerInstanceId, EntityCharacter triggerEntity, EntityCharacter ownerEntity) { }

	// RVA: 0x66BCF3C Offset: 0x66B8F3C VA: 0x66BCF3C
	private void HandleMissTriggerOnBullet(BulletHurtInfo hurtInfo) { }

	// RVA: 0x66BD474 Offset: 0x66B9474 VA: 0x66BD474
	private void HandlePostHitVisuals(BulletHurtInfo hurtInfo) { }

	// RVA: 0x66BD524 Offset: 0x66B9524 VA: 0x66BD524
	private void HandleCritLogic(BulletHurtInfo hurtInfo, EntityRef triggerInstanceId, EntityCharacter triggerEntity, EntityCharacter ownerEntity, EntityBullet bullet, bool isCri) { }

	// RVA: 0x66BDDD0 Offset: 0x66B9DD0 VA: 0x66BDDD0
	private void HandleBulletHitEnemy(BulletHurtInfo hurtInfo, EntityBullet bullet) { }

	// RVA: 0x66B8350 Offset: 0x66B4350 VA: 0x66B8350
	private void HandleBulletHitEventToBullet(EntityComponentEventId eventId, BulletHurtInfo hurtInfo, EntityBullet bullet, BulletFlag bulletFlag, int allAttack, HurtSourceData sourceData) { }

	// RVA: 0x66BE064 Offset: 0x66BA064 VA: 0x66BE064
	private void HandleHitBack(BulletHurtInfo hurtInfo, EntityBullet bullet) { }

	// RVA: 0x66BF220 Offset: 0x66BB220 VA: 0x66BF220
	public Dictionary<ValueTuple<EntityRef, EntityCharacterTypeKey>, CharacterComponentOnHit.WeaponHittedCountData> GetWeaponHittedCountDict() { }

	// RVA: 0x66BBBD8 Offset: 0x66B7BD8 VA: 0x66BBBD8
	private int UpdateWeaponHittedCount(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BBE1C Offset: 0x66B7E1C VA: 0x66BBE1C
	private int UpdateWeaponHittedCount1s(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BF284 Offset: 0x66BB284 VA: 0x66BF284
	public int GetWeaponHittedCount(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BF434 Offset: 0x66BB434 VA: 0x66BF434
	public int GetWeaponHittedCount1s(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BF5E4 Offset: 0x66BB5E4 VA: 0x66BF5E4
	public int GetWeaponHittedCountByComboInterval(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey, ComboIntervalType comboInterval) { }

	// RVA: 0x66BC060 Offset: 0x66B8060 VA: 0x66BC060
	public int UpdateWeaponIdHittedCount(EntityRef hitSource, int weaponId) { }

	// RVA: 0x66BC294 Offset: 0x66B8294 VA: 0x66BC294
	public int UpdateWeaponIdHittedCount1s(EntityRef hitSource, int weaponId) { }

	// RVA: 0x66BF69C Offset: 0x66BB69C VA: 0x66BF69C
	public int GetWeaponIdHittedCount(EntityRef hitSource, int weaponId) { }

	// RVA: 0x66BF848 Offset: 0x66BB848 VA: 0x66BF848
	public int GetWeaponIdHittedCount1s(EntityRef hitSource, int weaponId) { }

	// RVA: 0x66BF9F4 Offset: 0x66BB9F4 VA: 0x66BF9F4
	public int GetWeaponIdHittedCountByComboInterval(EntityRef hitSource, int weaponId, ComboIntervalType comboInterval) { }

	// RVA: 0x66BFAAC Offset: 0x66BBAAC VA: 0x66BFAAC
	public void ClearWeaponHittedCountOnce(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BFC4C Offset: 0x66BBC4C VA: 0x66BFC4C
	public void ClearWeaponHittedCountOnce1s(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey) { }

	// RVA: 0x66BC7E8 Offset: 0x66B87E8 VA: 0x66BC7E8
	private bool TryMarkSameEnemyMilestoneExplosionFired(EntityRef hitSource, EntityCharacterTypeKey weaponHittedCountKey, ComboIntervalType comboInterval, int hitCount) { }

	// RVA: 0x66BB9DC Offset: 0x66B79DC VA: 0x66BB9DC
	public static EntityCharacterTypeKey GetWeaponHittedCountKey(EntityCharacter ownerEntity) { }

	// RVA: 0x66BFDEC Offset: 0x66BBDEC VA: 0x66BFDEC
	public static EntityCharacterTypeKey GetWeaponHittedCountKey(EntityCharacterType characterType, int secondWeapenType) { }

	// RVA: 0x66BFE6C Offset: 0x66BBE6C VA: 0x66BFE6C Slot: 11
	public override void Init() { }

	// RVA: 0x66BFF14 Offset: 0x66BBF14 VA: 0x66BFF14 Slot: 12
	public override void DeInit() { }

	// RVA: 0x66B9734 Offset: 0x66B5734 VA: 0x66B9734
	private bool IsLaserBullet(BulletType bulletType) { }

	// RVA: 0x66C0058 Offset: 0x66BC058 VA: 0x66C0058
	private void CheckLaserStackCooldown() { }

	// RVA: 0x66C0298 Offset: 0x66BC298 VA: 0x66C0298
	public void SetLaserStackCooldown(FP cooldown) { }

	// RVA: 0x66C0350 Offset: 0x66BC350 VA: 0x66C0350
	public FP GetLaserStackCooldown() { }

	[CompilerGenerated]
	// RVA: 0x66C0454 Offset: 0x66BC454 VA: 0x66C0454
	public void add_OnHurtElapsedTimeChanged(Action<FP> value) { }

	[CompilerGenerated]
	// RVA: 0x66C0544 Offset: 0x66BC544 VA: 0x66C0544
	public void remove_OnHurtElapsedTimeChanged(Action<FP> value) { }

	// RVA: 0x66C0634 Offset: 0x66BC634 VA: 0x66C0634
	public FP get_LastHurtTimestamp() { }

	// RVA: 0x66C0698 Offset: 0x66BC698 VA: 0x66C0698
	public FP get_ElapsedSinceLastHurt() { }

	// RVA: 0x66C06FC Offset: 0x66BC6FC VA: 0x66C06FC Slot: 14
	public override void OnUpdate(FP deltaTime) { }

	// RVA: 0x66C077C Offset: 0x66BC77C VA: 0x66C077C
	private void UpdateHurtElapsedTime() { }

	// RVA: 0x66C08F0 Offset: 0x66BC8F0 VA: 0x66C08F0
	private void ResetHurtTimestamp() { }

	// RVA: 0x66C0854 Offset: 0x66BC854 VA: 0x66C0854
	private void NotifyHurtElapsedTimeChanged(FP elapsed) { }

	// RVA: 0x66C09B0 Offset: 0x66BC9B0 VA: 0x66C09B0 Slot: 15
	public override void OnLateUpdate(FP deltaTime) { }

	// RVA: 0x66C0A24 Offset: 0x66BCA24 VA: 0x66C0A24
	public void BodyHit(EntityCharacter attacker) { }

	// RVA: 0x66C14C0 Offset: 0x66BD4C0 VA: 0x66C14C0 Slot: 16
	public override void OnEvent(EntityComponentEventId id, object[] args) { }

	// RVA: 0x66C1B58 Offset: 0x66BDB58 VA: 0x66C1B58
	private void UpdateHitTime() { }

	// RVA: 0x66C1C10 Offset: 0x66BDC10 VA: 0x66C1C10
	public bool IsHitTimeOk() { }

	// RVA: 0x66B7518 Offset: 0x66B3518 VA: 0x66B7518
	private bool CheckAndUpdateHitTime() { }

	// RVA: 0x66BDA9C Offset: 0x66B9A9C VA: 0x66BDA9C
	private void DispatchDamageRenderEvent(FPVector3 hurtDir, HurtAttackerType attackerType) { }

	// RVA: 0x66C1EC8 Offset: 0x66BDEC8 VA: 0x66C1EC8
	internal void DoSimpleHurt(HurtAttackerType hurtType, FP damage, FPVector3 hurtDir, EntityRef attacker, bool onlyHurt) { }

	// RVA: 0x66C235C Offset: 0x66BE35C VA: 0x66C235C
	private int FixDamage(FP damage) { }

	// RVA: 0x66C1FF8 Offset: 0x66BDFF8 VA: 0x66C1FF8
	private void DoSimpleHurt(HurtAttackerType hurtType, FP damage, EntityRef attacker) { }

	// RVA: 0x66BEC34 Offset: 0x66BAC34 VA: 0x66BEC34
	private void PlayerHitAnimation() { }

	// RVA: 0x66B7188 Offset: 0x66B3188 VA: 0x66B7188
	private void dispatchHittedTriggerEvent(HurtAttackerType hitType) { }

	// RVA: 0x66B8C7C Offset: 0x66B4C7C VA: 0x66B8C7C
	private HurtDataArray BuildHurtDataArray(HurtSourceData sourceData, AttackSourceInfo attackInfo) { }

	// RVA: 0x66B8AB0 Offset: 0x66B4AB0 VA: 0x66B8AB0
	private HurtSourceData CreateHurtSourceDataFromAttackInfo(AttackSourceInfo attackInfo) { }

	// RVA: 0x66C0AA0 Offset: 0x66BCAA0 VA: 0x66C0AA0
	private void OnHitByBody(EntityCharacter attacker) { }

	// RVA: 0x66C1850 Offset: 0x66BD850 VA: 0x66C1850
	private void RecoverHp(int value, Nullable<HurtDeltaHpSourceInfo> deltaHpSource) { }

	// RVA: 0x66C269C Offset: 0x66BE69C VA: 0x66C269C
	public void Heal(FP value, Nullable<HurtDeltaHpSourceInfo> deltaHpSource) { }

	// RVA: 0x66BC928 Offset: 0x66B8928 VA: 0x66BC928
	public void HealSelfByPercent(FP value, FP percent, Nullable<HurtDeltaHpSourceInfo> deltaHpSource) { }

	// RVA: 0x66C2754 Offset: 0x66BE754 VA: 0x66C2754
	public void SetDyingHp(int hp) { }

	// RVA: 0x66BCA88 Offset: 0x66B8A88 VA: 0x66BCA88
	private bool OnHitUpdateHP(HurtSourceData sourceData, HurtDataArray hurtData, bool isMainWeapon, out bool isCri, out int allAttack, FPVector3 bulletPos, EntityRef bulletInstanceId, int bulletEntityId = 0) { }

	// RVA: 0x66C2820 Offset: 0x66BE820 VA: 0x66C2820
	private CharacterComponentOnHit.DamageCalculationResult CalculateDamage(HurtSourceData sourceData, HurtDataArray hurtData, out bool isCri, out bool isSecKill) { }

	// RVA: 0x66C2C94 Offset: 0x66BEC94 VA: 0x66C2C94
	private void HandlePreHpUpdateTriggers(HurtSourceData sourceData, ref int allAttack, bool isCri, FPVector3 bulletPos, EntityRef bulletInstanceId, int bulletEntityId) { }

	// RVA: 0x66C481C Offset: 0x66C081C VA: 0x66C481C
	private void HandlePostHpUpdateTriggers(HurtSourceData sourceData, ref int allAttack, bool isCri, FPVector3 bulletPos, EntityRef bulletInstanceId, int bulletEntityId) { }

	// RVA: 0x66C40E0 Offset: 0x66C00E0 VA: 0x66C40E0
	private void UpdateEntityHp(HurtSourceData sourceData, int allAttack, bool isMainWeapon, FPVector3 bulletPos, EntityRef bulletInstanceId, int bulletEntityId) { }

	// RVA: 0x66C4528 Offset: 0x66C0528 VA: 0x66C4528
	private void HandlePostHpUpdateEffects(HurtSourceData sourceData) { }

	// RVA: 0x66C5144 Offset: 0x66C1144 VA: 0x66C5144
	internal void CheckAndSetPreventEjectCountFlagsForNonHurtHit(EntityBullet bullet) { }

	// RVA: 0x66C3DE0 Offset: 0x66BFDE0 VA: 0x66C3DE0
	private void CheckAndSetPreventEjectCountFlags(HurtSourceData sourceData, EntityRef bulletInstanceId) { }

	// RVA: 0x66C5270 Offset: 0x66C1270 VA: 0x66C5270
	private void CheckAndSetPreventEjectCountFlagsCore(EntityBullet bullet, EntityCharacter ownerEntity) { }

	// RVA: 0x66C5694 Offset: 0x66C1694 VA: 0x66C5694
	private void CheckHurtReduce(ref FP damageDecreasePercent, AttributeData curAttribute, string attrName) { }

	// RVA: 0x66BE654 Offset: 0x66BA654 VA: 0x66BE654
	private void PlayEntityHitSound() { }

	// RVA: 0x66BE8C4 Offset: 0x66BA8C4 VA: 0x66BE8C4
	private void PlayVibartion() { }

	// RVA: -1 Offset: -1
	private void NotifyFollowers<T>(T triggerEvent, Action<EntityCharacter, T> notificationAction, Action<EntityHero, T> additionalAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454D854 Offset: 0x4549854 VA: 0x454D854
	|-CharacterComponentOnHit.NotifyFollowers<object>
	*/

	// RVA: 0x66C4D6C Offset: 0x66C0D6C VA: 0x66C4D6C
	internal void NotifyFollowersOnHeroHurt(HurtTriggerEvent triggerEvent) { }

	// RVA: 0x66C4FFC Offset: 0x66C0FFC VA: 0x66C4FFC
	internal void NotifyFollowersOnHeroHurtAfterHPChange(HurtAfterHPChangeTriggerEvent triggerEvent) { }

	// RVA: 0x66C1D80 Offset: 0x66BDD80 VA: 0x66C1D80
	internal void NotifyFollowersOnHeroInvHurt(InvHurtTriggerEvent triggerEvent) { }

	// RVA: 0x66C4EB4 Offset: 0x66C0EB4 VA: 0x66C4EB4
	internal void NotifyFollowersOnHeroDying(DyingTriggerEvent triggerEvent) { }

	// RVA: 0x66C5754 Offset: 0x66C1754 VA: 0x66C5754
	internal void NotifyFollowersOnHeroHpChange(HpChangeEvent triggerEvent) { }

	// RVA: 0x66C589C Offset: 0x66C189C VA: 0x66C589C
	internal void NotifyFollowersOnHeroMaxHpChange(MaxHpChangeTriggerEvent triggerEvent) { }

	// RVA: 0x66C2554 Offset: 0x66BE554 VA: 0x66C2554
	internal void NotifyFollowersOnHeroHitted(HittedTriggerEvent triggerEvent) { }

	// RVA: 0x66C59E4 Offset: 0x66C19E4 VA: 0x66C59E4
	internal void NotifyFollowersOnHeroDiscreteDistance(HeroDiscreteDistanceTriggerEvent triggerEvent) { }

	// RVA: 0x66C5B2C Offset: 0x66C1B2C VA: 0x66C5B2C
	internal void NotifyFollowersOnHeroDropItem(DropItemTriggerEvent triggerEvent) { }

	// RVA: 0x66BE50C Offset: 0x66BA50C VA: 0x66BE50C
	internal void NotifyFollowersOnHeroMiss(MissTriggerEvent triggerEvent) { }

	// RVA: 0x66C5C74 Offset: 0x66C1C74 VA: 0x66C5C74
	internal void NotifyFollowersOnHeroAddBuff(CharacterAddBuffTriggerEvent triggerEvent) { }

	// RVA: 0x66C5DBC Offset: 0x66C1DBC VA: 0x66C5DBC
	internal void NotifyFollowersOnHeroSkillSelected() { }

	// RVA: 0x66BEF20 Offset: 0x66BAF20 VA: 0x66BEF20
	private void ProcessCritTrigger(EntityCharacter entity, BulletHurtInfo hurtInfo, EntityRef attackerInstanceId, EntityBullet bullet) { }

	// RVA: 0x66C5EFC Offset: 0x66C1EFC VA: 0x66C5EFC
	public void .ctor() { }

	// RVA: 0x66C60DC Offset: 0x66C20DC VA: 0x66C60DC
	private static void .cctor() { }
}

