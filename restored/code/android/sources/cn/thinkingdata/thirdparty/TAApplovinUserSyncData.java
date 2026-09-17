package cn.thinkingdata.thirdparty;

import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.Iterator;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TAApplovinUserSyncData extends AbstractSyncThirdData {
    private Object mObj;
    private ThinkingAnalyticsSDK mThinkingSdk;

    public TAApplovinUserSyncData(ThinkingAnalyticsSDK thinkingAnalyticsSDK, Object obj) {
        this.mThinkingSdk = thinkingAnalyticsSDK;
        this.mObj = obj;
    }

    private Object getApplovinInstance() throws NoSuchFieldException {
        Field declaredField = Class.forName("com.applovin.sdk.AppLovinSdk").getDeclaredField("sdkInstances");
        declaredField.setAccessible(true);
        Map map = (Map) declaredField.get(null);
        if (map != null) {
            Iterator it = map.keySet().iterator();
            if (it.hasNext()) {
                return map.get((String) it.next());
            }
        }
        return null;
    }

    private Method getDeclaredMethod(Object obj, String str, Class<?>... clsArr) {
        for (Class<?> superclass = obj.getClass(); superclass != Object.class && superclass != null; superclass = superclass.getSuperclass()) {
            try {
                return superclass.getDeclaredMethod(str, clsArr);
            } catch (NoSuchMethodException unused) {
            }
        }
        return null;
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        Object objInvoke;
        Object objInvoke2;
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to ApplovinUser");
        try {
            if (this.mObj == null) {
                TDLog.e("ThinkingAnalytics.SyncData", "ApplovinUser data synchronization error : object is null");
                return;
            }
            JSONObject jSONObject = new JSONObject();
            Object obj = this.mObj;
            if (obj instanceof Map) {
                Map<String, Object> mapHandleMap = handleMap(obj);
                if (mapHandleMap != null) {
                    for (String str : mapHandleMap.keySet()) {
                        jSONObject.put(str, mapHandleMap.get(str));
                    }
                }
            } else {
                obj.getClass();
                Method declaredMethod = getDeclaredMethod(this.mObj, "getRevenue", new Class[0]);
                if (declaredMethod != null) {
                    jSONObject.put("revenue", declaredMethod.invoke(this.mObj, new Object[0]));
                }
                Method declaredMethod2 = getDeclaredMethod(this.mObj, "getNetworkName", new Class[0]);
                if (declaredMethod2 != null) {
                    jSONObject.put("networkName", declaredMethod2.invoke(this.mObj, new Object[0]));
                }
                Method declaredMethod3 = getDeclaredMethod(this.mObj, "getAdUnitId", new Class[0]);
                if (declaredMethod3 != null) {
                    jSONObject.put("adUnitId", declaredMethod3.invoke(this.mObj, new Object[0]));
                }
                Method declaredMethod4 = getDeclaredMethod(this.mObj, "getFormat", new Class[0]);
                if (declaredMethod4 != null && (objInvoke2 = declaredMethod4.invoke(this.mObj, new Object[0])) != null) {
                    jSONObject.put("adFormat", objInvoke2.toString());
                }
                Method declaredMethod5 = getDeclaredMethod(this.mObj, "getPlacement", new Class[0]);
                if (declaredMethod5 != null) {
                    jSONObject.put("placement", declaredMethod5.invoke(this.mObj, new Object[0]));
                }
                Object applovinInstance = getApplovinInstance();
                if (applovinInstance != null && (objInvoke = applovinInstance.getClass().getMethod("getConfiguration", new Class[0]).invoke(applovinInstance, new Object[0])) != null) {
                    jSONObject.put("countryCode", objInvoke.getClass().getMethod("getCountryCode", new Class[0]).invoke(objInvoke, new Object[0]));
                }
            }
            ThinkingAnalyticsSDK thinkingAnalyticsSDK = this.mThinkingSdk;
            if (thinkingAnalyticsSDK != null) {
                thinkingAnalyticsSDK.track(TAThirdConstants.APPLOVIN_EVENT_NAME, jSONObject);
            }
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to ApplovinUser success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "ApplovinUs[ThinkingData] Info: enabled sharing of data to ApplovinUser error:" + e.getMessage());
        }
    }
}
