package cn.thinkingdata.analytics.aop.push;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.analytics.h.r.a;
import cn.thinkingdata.analytics.h.r.b;
import java.io.Serializable;
import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TAPushUtils {
    private static final String TA_PUSH_CLICK_EVENT = "te_ops_push_click";
    public static List<String> gtMsgList = new ArrayList();

    public static boolean handleBundleExtraData(Intent intent) {
        if (intent == null) {
            return false;
        }
        try {
            Bundle extras = intent.getExtras();
            if (extras != null) {
                return trackPushClickEvent(extras.getString("te_extras"));
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    public static void handleExtraReceiverData(String str) {
        try {
            if (TextUtils.isEmpty(str)) {
                return;
            }
            trackPushClickEvent(new JSONObject(str).optString("te_extras"));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void handleGtPushEvent(String str, String str2) {
        if (gtMsgList.remove(str2)) {
            handleExtraReceiverData(str);
        }
    }

    public static boolean handleIntentExtraData(Intent intent) {
        if (intent == null) {
            return false;
        }
        try {
            return trackPushClickEvent(intent.getStringExtra("te_extras"));
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }

    private static boolean handleJPushIntentData(Intent intent) {
        if (intent == null) {
            return false;
        }
        try {
            JSONObject jSONObject = null;
            String string = intent.getData() != null ? intent.getData().toString() : null;
            if (TextUtils.isEmpty(string) && intent.getExtras() != null) {
                string = intent.getExtras().getString("JMessageExtra");
            }
            if (string != null && !TextUtils.isEmpty(string)) {
                Object objOpt = new JSONObject(string).opt("n_extras");
                if (objOpt instanceof String) {
                    jSONObject = new JSONObject((String) objOpt);
                } else if (objOpt instanceof JSONObject) {
                    jSONObject = (JSONObject) objOpt;
                }
                if (jSONObject != null) {
                    return trackPushClickEvent(jSONObject.optString("te_extras"));
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    public static void handleMiPushData(Intent intent) {
        if (intent == null) {
            return;
        }
        try {
            Serializable serializableExtra = intent.getSerializableExtra("key_message");
            if (serializableExtra != null) {
                Object objInvoke = serializableExtra.getClass().getMethod("getExtra", new Class[0]).invoke(serializableExtra, new Object[0]);
                if (objInvoke instanceof Map) {
                    trackPushClickEvent((String) ((Map) objInvoke).get("te_extras"));
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void handlePushToken(JSONObject jSONObject) {
        a aVar = new a();
        aVar.d = "";
        aVar.c = jSONObject;
        aVar.e = 1;
        aVar.f129a = k.USER_SET;
        b.a(aVar);
    }

    public static void handlePushTokenAfterLogin(final ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        if (thinkingAnalyticsSDK.mConfig.mEnableAutoPush) {
            try {
                String str = (String) Class.forName("cn.jpush.android.api.JPushInterface").getDeclaredMethod("getRegistrationID", Context.class).invoke(null, thinkingAnalyticsSDK.mConfig.mContext);
                if (!TextUtils.isEmpty(str)) {
                    JSONObject jSONObject = new JSONObject();
                    jSONObject.put("jiguang_id", str);
                    thinkingAnalyticsSDK.user_set(jSONObject);
                    thinkingAnalyticsSDK.flush();
                }
            } catch (Exception unused) {
            }
            try {
                Class<?> cls = Class.forName("com.google.firebase.messaging.FirebaseMessaging");
                Object objInvoke = cls.getDeclaredMethod("getToken", new Class[0]).invoke(cls.getDeclaredMethod("getInstance", new Class[0]).invoke(null, new Object[0]), new Object[0]);
                if (objInvoke != null) {
                    Class<?> cls2 = Class.forName("com.google.android.gms.tasks.OnCompleteListener");
                    objInvoke.getClass().getMethod("addOnCompleteListener", cls2).invoke(objInvoke, Proxy.newProxyInstance(cls.getClassLoader(), new Class[]{cls2}, new InvocationHandler() { // from class: cn.thinkingdata.analytics.aop.push.TAPushUtils.1
                        @Override // java.lang.reflect.InvocationHandler
                        public Object invoke(Object obj, Method method, Object[] objArr) {
                            try {
                                if ("onComplete".equals(method.getName())) {
                                    String str2 = (String) Class.forName("com.google.android.gms.tasks.Task").getDeclaredMethod("getResult", new Class[0]).invoke(objArr[0], new Object[0]);
                                    if (!TextUtils.isEmpty(str2)) {
                                        JSONObject jSONObject2 = new JSONObject();
                                        jSONObject2.put("fcm_token", str2);
                                        thinkingAnalyticsSDK.user_set(jSONObject2);
                                        thinkingAnalyticsSDK.flush();
                                    }
                                }
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                            return 0;
                        }
                    }));
                }
            } catch (Throwable th) {
                th.printStackTrace();
            }
        }
    }

    public static void handleStartIntent(Intent intent) {
        if (handleBundleExtraData(intent) || handleIntentExtraData(intent) || handleJPushIntentData(intent)) {
            return;
        }
        handleMiPushData(intent);
    }

    public static boolean trackPushClickEvent(String str) {
        JSONObject jSONObject;
        try {
            if (TextUtils.isEmpty(str)) {
                return false;
            }
            Object objOpt = new JSONObject(str).opt("#ops_receipt_properties");
            if (objOpt instanceof String) {
                jSONObject = new JSONObject((String) objOpt);
            } else {
                jSONObject = objOpt instanceof JSONObject ? (JSONObject) objOpt : null;
            }
            a aVar = new a();
            aVar.d = "";
            aVar.b = TA_PUSH_CLICK_EVENT;
            aVar.c = jSONObject;
            aVar.e = 1;
            aVar.f129a = k.TRACK;
            b.a(aVar);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return false;
    }
}
