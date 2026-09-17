package cn.thinkingdata.thirdparty;

import android.content.Context;
import android.os.Bundle;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.core.utils.TDLog;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.kuaishou.weapon.p0.t;
import java.lang.reflect.Field;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;
import java.util.Map;
import java.util.Set;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class FirebaseSyncData extends AbstractSyncThirdData {
    private final String eventNamePrefix;
    private final ThinkingAnalyticsSDK mThinkingSdk;
    private final String[] prefix;

    public FirebaseSyncData(ThinkingAnalyticsSDK thinkingAnalyticsSDK, String str) {
        super(str);
        this.prefix = new String[]{"a", t.l, "c", t.t, "e", "f", "g", "h", t.e, "j", t.f2732a, t.d, t.m, "n", "o", t.b, "q", t.k, t.g, "t", "u", t.c, IAdInterListener.AdReqParam.WIDTH, "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "_"};
        this.eventNamePrefix = "ta_";
        this.mThinkingSdk = thinkingAnalyticsSDK;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void handleEvent(Object[] objArr, final Class<?> cls, final Object obj) throws JSONException {
        if (objArr == null || objArr.length != 4) {
            return;
        }
        final String str = (String) objArr[0];
        final String str2 = (String) objArr[1];
        Bundle bundle = (Bundle) objArr[2];
        Set<String> setKeySet = bundle.keySet();
        final JSONObject jSONObject = new JSONObject();
        for (String str3 : setKeySet) {
            if (str3 != null && !str3.startsWith("_")) {
                jSONObject.put(str3, bundle.get(str3));
            }
        }
        ThirdPartyTaskManager.getExecutor().execute(new Runnable() { // from class: cn.thinkingdata.thirdparty.FirebaseSyncData.2
            @Override // java.lang.Runnable
            public void run() {
                try {
                    Method declaredMethod = cls.getDeclaredMethod("getUserProperties", String.class, String.class, Boolean.TYPE);
                    for (String str4 : FirebaseSyncData.this.prefix) {
                        Map map = (Map) declaredMethod.invoke(obj, str, str4, true);
                        if (map != null) {
                            for (String str5 : map.keySet()) {
                                if (!str5.startsWith("_")) {
                                    jSONObject.put(str5, map.get(str5));
                                } else if ("_id".equals(str5)) {
                                    jSONObject.put("userId", map.get(str5));
                                }
                            }
                        }
                    }
                    FirebaseSyncData.this.mThinkingSdk.track("ta_" + str2, jSONObject);
                } catch (Exception e) {
                    TDLog.d("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to firebase error：" + e.getMessage());
                }
            }
        });
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        ThirdPartyTaskManager.getExecutor().execute(new Runnable() { // from class: cn.thinkingdata.thirdparty.FirebaseSyncData.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    if (FirebaseSyncData.this.mThinkingSdk != null) {
                        Field declaredField = FirebaseSyncData.this.mThinkingSdk.getClass().getDeclaredField("mConfig");
                        declaredField.setAccessible(true);
                        Object obj = declaredField.get(FirebaseSyncData.this.mThinkingSdk);
                        if (obj != null) {
                            Field declaredField2 = obj.getClass().getDeclaredField("mContext");
                            declaredField2.setAccessible(true);
                            Object obj2 = declaredField2.get(obj);
                            if (obj2 instanceof Context) {
                                final Class<?> cls = Class.forName("com.google.android.gms.measurement.api.AppMeasurementSdk");
                                final Object objInvoke = cls.getDeclaredMethod("getInstance", Context.class).invoke(null, (Context) obj2);
                                Class<?> cls2 = Class.forName("com.google.android.gms.measurement.api.AppMeasurementSdk$OnEventListener");
                                cls.getDeclaredMethod("registerOnMeasurementEventListener", cls2).invoke(objInvoke, Proxy.newProxyInstance(cls.getClassLoader(), new Class[]{cls2}, new InvocationHandler() { // from class: cn.thinkingdata.thirdparty.FirebaseSyncData.1.1
                                    @Override // java.lang.reflect.InvocationHandler
                                    public Object invoke(Object obj3, Method method, Object[] objArr) throws JSONException {
                                        if (!"onEvent".equals(method.getName())) {
                                            return method.invoke(objInvoke, objArr);
                                        }
                                        FirebaseSyncData.this.handleEvent(objArr, cls, objInvoke);
                                        return 0;
                                    }
                                }));
                            }
                        }
                    }
                } catch (Exception e) {
                    TDLog.d("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to firebase error：" + e.getMessage());
                }
            }
        });
    }
}
