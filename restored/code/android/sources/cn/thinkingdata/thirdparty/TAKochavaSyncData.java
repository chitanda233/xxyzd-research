package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class TAKochavaSyncData extends AbstractSyncThirdData {
    private final Map<String, Object> mCustomMap;

    public TAKochavaSyncData(String str, String str2, Object obj) {
        super(str, str2);
        this.mCustomMap = handleMap(obj);
    }

    private void syncTracker_v4() {
        TDLog.d("ThinkingAnalytics.SyncData", "again start Kochava data synchronization");
        try {
            Class<?> cls = Class.forName("com.kochava.tracker.Tracker");
            Object objInvoke = cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]);
            Method method = cls.getMethod("registerIdentityLink", String.class, String.class);
            Map<String, Object> map = this.mCustomMap;
            if (map != null) {
                for (Map.Entry<String, Object> entry : map.entrySet()) {
                    method.invoke(objInvoke, entry.getKey(), entry.getValue() + "");
                }
            }
            method.invoke(objInvoke, TAThirdConstants.TA_ACCOUNT_ID, this.accountId);
            method.invoke(objInvoke, TAThirdConstants.TA_DISTINCT_ID, this.distinctId);
            TDLog.d("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to Kochava success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to Kochava error:" + e.getMessage());
            e.printStackTrace();
        }
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to Kochava");
        try {
            Class<?> cls = Class.forName("com.kochava.base.Tracker");
            Class<?> cls2 = Class.forName("com.kochava.base.Tracker$IdentityLink");
            Object objNewInstance = cls2.getConstructor(new Class[0]).newInstance(new Object[0]);
            Method method = cls2.getMethod("add", Map.class);
            HashMap map = new HashMap();
            map.put(TAThirdConstants.TA_DISTINCT_ID, this.distinctId);
            map.put(TAThirdConstants.TA_ACCOUNT_ID, this.accountId);
            Map<String, Object> map2 = this.mCustomMap;
            if (map2 != null) {
                for (Map.Entry<String, Object> entry : map2.entrySet()) {
                    map.put(entry.getKey(), entry.getValue() + "");
                }
            }
            method.invoke(objNewInstance, map);
            cls.getMethod("setIdentityLink", cls2).invoke(null, objNewInstance);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to Kochava success");
        } catch (ClassNotFoundException e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to Kochava error:" + e.getMessage());
            syncTracker_v4();
        } catch (Exception e2) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to Kochava error:" + e2.getMessage());
        }
    }
}
