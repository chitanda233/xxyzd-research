package cn.thinkingdata.thirdparty;

import android.content.Context;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class AdjustSyncData extends AbstractSyncThirdData {
    private final ThinkingAnalyticsSDK mThinkingSdk;

    public AdjustSyncData(String str, String str2, ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        super(str, str2);
        this.mThinkingSdk = thinkingAnalyticsSDK;
    }

    private void syncUserOperation(Object obj, Class<?> cls) {
        if (obj instanceof Context) {
            try {
                Class<?> cls2 = Class.forName("com.adjust.sdk.OnDeviceIdsRead");
                cls.getMethod("getGoogleAdId", Context.class, cls2).invoke(null, (Context) obj, Proxy.newProxyInstance(cls.getClassLoader(), new Class[]{cls2}, new InvocationHandler() { // from class: cn.thinkingdata.thirdparty.AdjustSyncData.1
                    @Override // java.lang.reflect.InvocationHandler
                    public Object invoke(Object obj2, Method method, Object[] objArr) throws JSONException {
                        if ("onGoogleAdIdRead".equals(method.getName()) && objArr != null && objArr.length == 1) {
                            Object obj3 = objArr[0];
                            if (obj3 instanceof String) {
                                JSONObject jSONObject = new JSONObject();
                                jSONObject.put("GAID", (String) obj3);
                                AdjustSyncData.this.mThinkingSdk.user_set(jSONObject);
                            }
                        }
                        return 0;
                    }
                }));
            } catch (Exception e) {
                TDLog.e("ThinkingAnalytics.SyncData", "Adjust get GoogleAdId fail:" + e.getMessage());
            }
        }
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        Method method;
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to adjust");
        try {
            Class<?> cls = Class.forName("com.adjust.sdk.Adjust");
            try {
                method = cls.getMethod("addSessionCallbackParameter", String.class, String.class);
            } catch (Exception unused) {
                method = cls.getMethod("addGlobalCallbackParameter", String.class, String.class);
            }
            Object[] objArr = new Object[2];
            objArr[0] = TAThirdConstants.TA_DISTINCT_ID;
            String str = "";
            objArr[1] = this.distinctId == null ? "" : this.distinctId;
            method.invoke(null, objArr);
            Object[] objArr2 = new Object[2];
            objArr2[0] = TAThirdConstants.TA_ACCOUNT_ID;
            if (this.accountId != null) {
                str = this.accountId;
            }
            objArr2[1] = str;
            method.invoke(null, objArr2);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to adjust success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to adjust error", e);
        }
    }
}
