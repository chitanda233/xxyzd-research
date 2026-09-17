package cn.thinkingdata.thirdparty;

import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;

/* JADX INFO: loaded from: classes.dex */
public class TAThirdPartyManager {
    public static void enableThirdPartySharing(int i, ThinkingAnalyticsSDK thinkingAnalyticsSDK, String str) {
        if ((i & 1) > 0) {
            enableThirdPartySharing(1, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 2) > 0) {
            enableThirdPartySharing(2, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 4) > 0) {
            enableThirdPartySharing(4, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 8) > 0) {
            enableThirdPartySharing(8, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 16) > 0) {
            enableThirdPartySharing(16, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 32) > 0) {
            enableThirdPartySharing(32, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 64) > 0) {
            enableThirdPartySharing(64, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 128) > 0) {
            enableThirdPartySharing(128, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 256) > 0) {
            enableThirdPartySharing(256, thinkingAnalyticsSDK, str, null);
        }
        if ((i & 1024) > 0) {
            enableThirdPartySharing(1024, thinkingAnalyticsSDK, str, null);
        }
    }

    public static void enableThirdPartySharing(int i, ThinkingAnalyticsSDK thinkingAnalyticsSDK, String str, Object obj) {
        ISyncThirdPartyData iSyncThirdPartyDataCreate = TAThirdPartyFactory.create(i, thinkingAnalyticsSDK, str, obj);
        if (iSyncThirdPartyDataCreate != null) {
            iSyncThirdPartyDataCreate.syncThirdPartyData();
        }
    }
}
