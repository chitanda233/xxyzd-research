package cn.thinkingdata.thirdparty;

import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;
import java.util.HashSet;
import java.util.Iterator;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class IronSourceSyncData extends AbstractSyncThirdData {
    private final ThinkingAnalyticsSDK mThinkingSdk;

    public IronSourceSyncData(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        this.mThinkingSdk = thinkingAnalyticsSDK;
    }

    private boolean checkHasAddListener() {
        try {
            Class<?> cls = Class.forName("com.ironsource.mediationsdk.IronsourceObjectPublisherDataHolder");
            Object objInvoke = cls.getMethod("getImpressionDataListeners", new Class[0]).invoke(cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]), new Object[0]);
            if (!(objInvoke instanceof HashSet)) {
                return false;
            }
            Iterator it = ((HashSet) objInvoke).iterator();
            while (it.hasNext()) {
                if (it.next().getClass().getName().startsWith("$Proxy")) {
                    return true;
                }
            }
            return false;
        } catch (Exception unused) {
            return false;
        }
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to IronSource");
        if (checkHasAddListener()) {
            TDLog.e("ThinkingAnalytics.SyncData", "IronSource Data has been synchronized.");
            return;
        }
        try {
            Class<?> cls = Class.forName("com.ironsource.mediationsdk.IronSource");
            Class<?> cls2 = Class.forName("com.ironsource.mediationsdk.impressionData.ImpressionDataListener");
            cls.getMethod("addImpressionDataListener", cls2).invoke(null, Proxy.newProxyInstance(cls.getClassLoader(), new Class[]{cls2}, new InvocationHandler() { // from class: cn.thinkingdata.thirdparty.IronSourceSyncData.1
                @Override // java.lang.reflect.InvocationHandler
                public Object invoke(Object obj, Method method, Object[] objArr) {
                    if ("onImpressionSuccess".equals(method.getName()) && objArr != null && objArr.length == 1) {
                        try {
                            Object objInvoke = Class.forName("com.ironsource.mediationsdk.impressionData.ImpressionData").getMethod("getAllData", new Class[0]).invoke(objArr[0], new Object[0]);
                            if (objInvoke instanceof JSONObject) {
                                JSONObject jSONObject = (JSONObject) objInvoke;
                                if (IronSourceSyncData.this.mThinkingSdk != null) {
                                    IronSourceSyncData.this.mThinkingSdk.track(TAThirdConstants.IRON_SOURCE_EVENT_NAME, jSONObject);
                                }
                            }
                        } catch (Exception unused) {
                        }
                    }
                    return 0;
                }
            }));
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to IronSource success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to IronSource error:" + e.getMessage());
        }
    }
}
