package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class AppsFlyerSyncData extends AbstractSyncThirdData {
    private final Map<String, Object> mCustomMap;

    public AppsFlyerSyncData(String str, String str2, Object obj) {
        super(str, str2);
        this.mCustomMap = handleMap(obj);
    }

    private void syncThirdPartyData5(Map<String, Object> map) {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to appsflyer5");
        try {
            Class<?> cls = Class.forName("com.appsflyer.AppsFlyerLib");
            cls.getMethod("setAdditionalData", HashMap.class).invoke(cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]), (HashMap) map);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to appsflyer5 success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to appsflyer5 error:", e);
        }
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to appsflyer");
        HashMap map = new HashMap();
        String str = this.distinctId;
        if (str == null) {
            str = "";
        }
        map.put(TAThirdConstants.TA_DISTINCT_ID, str);
        String str2 = this.accountId;
        map.put(TAThirdConstants.TA_ACCOUNT_ID, str2 != null ? str2 : "");
        Map<String, Object> map2 = this.mCustomMap;
        if (map2 != null) {
            for (Map.Entry<String, Object> entry : map2.entrySet()) {
                map.put(entry.getKey(), entry.getValue());
            }
        }
        try {
            Class<?> cls = Class.forName("com.appsflyer.AppsFlyerLib");
            Object objInvoke = cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]);
            cls.getMethod("setAdditionalData", Map.class).invoke(objInvoke, map);
            if (this.distinctId != null) {
                cls.getDeclaredMethod("setCustomerUserId", String.class).invoke(objInvoke, this.distinctId);
            }
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to appsflyer success");
        } catch (NoSuchMethodException e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to appsflyer error:", e);
            syncThirdPartyData5(map);
        } catch (Exception e2) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to appsflyer error:", e2);
        }
    }
}
