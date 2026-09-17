package com.gorilla.plugin.shanyan;

import android.app.Activity;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import com.alipay.sdk.app.AlipayApi;
import com.alipay.sdk.m.k0.c;
import com.byazt.nys.PluginConstants;
import com.chuanglan.shanyan_sdk.OneKeyLoginManager;
import com.chuanglan.shanyan_sdk.listener.ActionListener;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoListener;
import com.chuanglan.shanyan_sdk.listener.InitListener;
import com.chuanglan.shanyan_sdk.listener.OneKeyLoginListener;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthListener;
import com.czhj.sdk.common.Constants;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.n;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ShanYanService {
    private static final String CALLBACK_TYPE_EVENT = "event";
    private static final ShanYanService INSTANCE = new ShanYanService();
    private static final Handler mainHandler = new Handler(Looper.getMainLooper());

    private String resolveEventType(int i) {
        if (i == 1) {
            return "protocol_clicked";
        }
        if (i == 2) {
            return "checkbox_changed";
        }
        if (i != 3) {
            return null;
        }
        return "login_button_clicked";
    }

    public static ShanYanService getInstance() {
        return INSTANCE;
    }

    private ShanYanService() {
    }

    public void doInit(Activity activity, JSONObject jSONObject, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback) {
        String strOptString = optString(jSONObject, AlipayApi.c, null);
        if (TextUtils.isEmpty(strOptString)) {
            fail(iFailureCallback, -1, "ShanYan appId is required.");
            return;
        }
        if (optBoolean(jSONObject, "enableLogger", false)) {
            OneKeyLoginManager.getInstance().setDebug(true);
        }
        OneKeyLoginManager.getInstance().ipv6Enable(true);
        OneKeyLoginManager.getInstance().init(activity.getApplicationContext(), strOptString, new InitListener() { // from class: com.gorilla.plugin.shanyan.ShanYanService.1
            @Override // com.chuanglan.shanyan_sdk.listener.InitListener
            public void getInitStatus(int i, String str) {
                if (i == 1022) {
                    ShanYanService shanYanService = ShanYanService.this;
                    shanYanService.emitSuccess(iSuccessCallback, shanYanService.buildPayload(c.p, "init success"));
                } else {
                    ShanYanService.this.fail(iFailureCallback, i, str);
                }
            }
        });
    }

    public void doPrepare(JSONObject jSONObject, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback) {
        OneKeyLoginManager.getInstance().setTimeOutForPreLogin(resolvePrepareTimeoutSeconds(jSONObject));
        OneKeyLoginManager.getInstance().getPhoneInfo(new GetPhoneInfoListener() { // from class: com.gorilla.plugin.shanyan.ShanYanService.2
            @Override // com.chuanglan.shanyan_sdk.listener.GetPhoneInfoListener
            public void getPhoneInfoStatus(int i, String str) {
                if (i == 1022) {
                    ShanYanService shanYanService = ShanYanService.this;
                    shanYanService.emitSuccess(iSuccessCallback, shanYanService.buildPreparePayload(true));
                } else {
                    ShanYanService.this.fail(iFailureCallback, i, str);
                }
            }
        });
    }

    public void doAuth(Activity activity, JSONObject jSONObject, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback) {
        ShanYanUIConfigHelper.applyConfig(activity, jSONObject);
        OneKeyLoginManager.getInstance().setActionListener(new ActionListener() { // from class: com.gorilla.plugin.shanyan.ShanYanService$$ExternalSyntheticLambda2
            @Override // com.chuanglan.shanyan_sdk.listener.ActionListener
            public final void ActionListner(int i, int i2, String str) {
                this.f$0.m160lambda$doAuth$0$comgorillapluginshanyanShanYanService(iSuccessCallback, i, i2, str);
            }
        });
        ShanYanSwitchLoginCallback.setListener(new ShanYanSwitchLoginCallback.Listener() { // from class: com.gorilla.plugin.shanyan.ShanYanService$$ExternalSyntheticLambda3
            @Override // com.gorilla.plugin.shanyan.ShanYanSwitchLoginCallback.Listener
            public final void onSwitchLogin() {
                this.f$0.m161lambda$doAuth$1$comgorillapluginshanyanShanYanService(iSuccessCallback);
            }
        });
        ShanYanCloseAuthCallback.setListener(new ShanYanCloseAuthCallback.Listener() { // from class: com.gorilla.plugin.shanyan.ShanYanService$$ExternalSyntheticLambda4
            @Override // com.gorilla.plugin.shanyan.ShanYanCloseAuthCallback.Listener
            public final void onCloseAuth() {
                this.f$0.m162lambda$doAuth$2$comgorillapluginshanyanShanYanService(iSuccessCallback);
            }
        });
        OneKeyLoginManager.getInstance().openLoginAuth(true, new OpenLoginAuthListener() { // from class: com.gorilla.plugin.shanyan.ShanYanService.3
            @Override // com.chuanglan.shanyan_sdk.listener.OpenLoginAuthListener
            public void getOpenLoginAuthStatus(int i, String str) {
                if (i == 1000) {
                    ShanYanService shanYanService = ShanYanService.this;
                    shanYanService.emitSuccess(iSuccessCallback, shanYanService.buildEventPayload("page_opened", n.i, "auth page opened", false, null));
                } else {
                    ShanYanService.this.fail(iFailureCallback, i, str);
                }
            }
        }, new OneKeyLoginListener() { // from class: com.gorilla.plugin.shanyan.ShanYanService.4
            @Override // com.chuanglan.shanyan_sdk.listener.OneKeyLoginListener
            public void getOneKeyLoginStatus(int i, String str) {
                if (i == 1000) {
                    String strExtractToken = ShanYanService.this.extractToken(str);
                    OneKeyLoginManager.getInstance().finishAuthActivity();
                    ShanYanCloseAuthCallback.setListener(null);
                    ShanYanSwitchLoginCallback.setListener(null);
                    ShanYanService shanYanService = ShanYanService.this;
                    shanYanService.emitSuccess(iSuccessCallback, shanYanService.buildLoginPayload(strExtractToken));
                    return;
                }
                if (i == 1011) {
                    ShanYanCloseAuthCallback.setListener(null);
                    ShanYanSwitchLoginCallback.setListener(null);
                    ShanYanService shanYanService2 = ShanYanService.this;
                    shanYanService2.emitSuccess(iSuccessCallback, shanYanService2.buildEventPayload("cancel", "1011", "user cancel", true, null));
                    return;
                }
                ShanYanCloseAuthCallback.setListener(null);
                ShanYanSwitchLoginCallback.setListener(null);
                ShanYanService.this.fail(iFailureCallback, i, str);
            }
        });
    }

    /* JADX INFO: renamed from: lambda$doAuth$0$com-gorilla-plugin-shanyan-ShanYanService, reason: not valid java name */
    /* synthetic */ void m160lambda$doAuth$0$comgorillapluginshanyanShanYanService(ISuccessCallback iSuccessCallback, int i, int i2, String str) {
        Boolean boolValueOf;
        String strResolveEventType = resolveEventType(i);
        if (strResolveEventType == null || iSuccessCallback == null) {
            return;
        }
        if (i == 2 || i == 3) {
            boolValueOf = Boolean.valueOf(i2 == 1);
        } else {
            boolValueOf = null;
        }
        emitSuccess(iSuccessCallback, buildEventPayload(strResolveEventType, String.valueOf(i2), str, false, boolValueOf));
    }

    /* JADX INFO: renamed from: lambda$doAuth$1$com-gorilla-plugin-shanyan-ShanYanService, reason: not valid java name */
    /* synthetic */ void m161lambda$doAuth$1$comgorillapluginshanyanShanYanService(ISuccessCallback iSuccessCallback) {
        ShanYanSwitchLoginCallback.setListener(null);
        emitSuccess(iSuccessCallback, buildEventPayload("switch_login", "SWITCH", "user switch login", true, null));
    }

    /* JADX INFO: renamed from: lambda$doAuth$2$com-gorilla-plugin-shanyan-ShanYanService, reason: not valid java name */
    /* synthetic */ void m162lambda$doAuth$2$comgorillapluginshanyanShanYanService(ISuccessCallback iSuccessCallback) {
        ShanYanCloseAuthCallback.setListener(null);
        emitSuccess(iSuccessCallback, buildEventPayload("cancel", "1011", "user cancel", true, null));
    }

    public void doDismiss(ISuccessCallback iSuccessCallback) {
        OneKeyLoginManager.getInstance().finishAuthActivity();
        ShanYanCloseAuthCallback.setListener(null);
        ShanYanSwitchLoginCallback.setListener(null);
        emitSuccess(iSuccessCallback, buildPayload("DISMISSED", "dismissed"));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String extractToken(String str) {
        if (TextUtils.isEmpty(str)) {
            return "";
        }
        try {
            return new JSONObject(str).optString(Constants.TOKEN, "");
        } catch (JSONException unused) {
            return "";
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String buildPayload(String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, str);
            jSONObject.put("message", str2);
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String buildPreparePayload(boolean z) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(PointCategory.READY, z);
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, c.p);
            jSONObject.put("message", "prepare success");
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String buildLoginPayload(String str) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(Constants.TOKEN, str);
            jSONObject.put("provider", "shanyan");
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, c.p);
            jSONObject.put("message", "login success");
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String buildEventPayload(String str, String str2, String str3, boolean z, Boolean bool) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("callbackType", "event");
            jSONObject.put("eventType", str);
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, str2);
            if (str3 == null) {
                str3 = "";
            }
            jSONObject.put("message", str3);
            jSONObject.put("terminal", z);
            if (bool != null) {
                jSONObject.put("isChecked", bool);
            }
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void emitSuccess(final ISuccessCallback iSuccessCallback, final String str) {
        if (iSuccessCallback == null) {
            return;
        }
        mainHandler.post(new Runnable() { // from class: com.gorilla.plugin.shanyan.ShanYanService$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                iSuccessCallback.onSuccess(str);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fail(final IFailureCallback iFailureCallback, final int i, final String str) {
        if (iFailureCallback == null) {
            return;
        }
        mainHandler.post(new Runnable() { // from class: com.gorilla.plugin.shanyan.ShanYanService$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                ShanYanService.lambda$fail$4(iFailureCallback, i, str);
            }
        });
    }

    static /* synthetic */ void lambda$fail$4(IFailureCallback iFailureCallback, int i, String str) {
        if (str == null) {
            str = "Unknown error";
        }
        iFailureCallback.onFailure(i, str);
    }

    private static String optString(JSONObject jSONObject, String str, String str2) {
        if (jSONObject == null) {
            return str2;
        }
        String strOptString = jSONObject.optString(str, null);
        return TextUtils.isEmpty(strOptString) ? str2 : strOptString;
    }

    private static boolean optBoolean(JSONObject jSONObject, String str, boolean z) {
        return jSONObject != null ? jSONObject.optBoolean(str, z) : z;
    }

    private static int optInt(JSONObject jSONObject, String str, int i) {
        return jSONObject != null ? jSONObject.optInt(str, i) : i;
    }

    private static int resolvePrepareTimeoutSeconds(JSONObject jSONObject) {
        int iOptInt = optInt(jSONObject, "timeoutMs", 3000);
        return Math.max(1, ((iOptInt > 0 ? iOptInt : 3000) + 999) / 1000);
    }
}
