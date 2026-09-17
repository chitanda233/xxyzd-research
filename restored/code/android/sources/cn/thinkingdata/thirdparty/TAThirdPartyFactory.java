package cn.thinkingdata.thirdparty;

import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;

/* JADX INFO: loaded from: classes.dex */
public class TAThirdPartyFactory {
    public static ISyncThirdPartyData create(int i, ThinkingAnalyticsSDK thinkingAnalyticsSDK, String str, Object obj) {
        if (i == 1) {
            return new AppsFlyerSyncData(thinkingAnalyticsSDK.getDistinctId(), str, obj);
        }
        if (i == 2) {
            return new IronSourceSyncData(thinkingAnalyticsSDK);
        }
        if (i == 4) {
            return new AdjustSyncData(thinkingAnalyticsSDK.getDistinctId(), str, thinkingAnalyticsSDK);
        }
        if (i == 8) {
            return new BranchSyncData(thinkingAnalyticsSDK.getDistinctId(), str);
        }
        if (i == 16) {
            return new TopOnSyncData(thinkingAnalyticsSDK.getDistinctId(), obj);
        }
        if (i == 32) {
            return new TrackingSyncData(thinkingAnalyticsSDK.getDistinctId());
        }
        if (i == 64) {
            return new TradPlusSyncData(thinkingAnalyticsSDK.getDistinctId());
        }
        if (i == 128) {
            return new TAKochavaSyncData(thinkingAnalyticsSDK.getDistinctId(), str, obj);
        }
        if (i == 256) {
            return new TAApplovinImpressionSyncData(thinkingAnalyticsSDK.getDistinctId());
        }
        if (i == 512) {
            return new TAApplovinUserSyncData(thinkingAnalyticsSDK, obj);
        }
        if (i != 1024) {
            return null;
        }
        return new FirebaseSyncData(thinkingAnalyticsSDK, thinkingAnalyticsSDK.getDistinctId());
    }
}
