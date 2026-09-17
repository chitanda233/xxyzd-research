package com.gorilla.base.service;

import android.app.Activity;
import android.content.ActivityNotFoundException;
import android.content.Intent;
import android.net.Uri;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import com.alipay.sdk.m.k0.c;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.byazt.nys.PluginConstants;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class SystemSmsService {
    private static final Handler MAIN_HANDLER = new Handler(Looper.getMainLooper());

    private SystemSmsService() {
    }

    public static void send(Activity activity, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        if (activity == null) {
            fail(iFailureCallback, -1, "Activity is null.");
            return;
        }
        String strOptString = optString(jSONObject, "phoneNumber");
        String strOptString2 = optString(jSONObject, IAdInterListener.AdProdType.PRODUCT_CONTENT);
        if (TextUtils.isEmpty(strOptString)) {
            fail(iFailureCallback, -1, "phoneNumber is required.");
            return;
        }
        Intent intent = new Intent("android.intent.action.SENDTO");
        intent.setData(Uri.parse("smsto:" + Uri.encode(strOptString)));
        if (!TextUtils.isEmpty(strOptString2)) {
            intent.putExtra("sms_body", strOptString2);
        }
        if (intent.resolveActivity(activity.getPackageManager()) == null) {
            fail(iFailureCallback, -1, "No SMS application available.");
            return;
        }
        try {
            activity.startActivity(intent);
            emitSuccess(iSuccessCallback, buildPayload(c.p, "sms composer opened"));
        } catch (ActivityNotFoundException unused) {
            fail(iFailureCallback, -1, "No SMS application available.");
        } catch (Exception e) {
            fail(iFailureCallback, -1, e.getMessage());
        }
    }

    private static void emitSuccess(final ISuccessCallback iSuccessCallback, final String str) {
        if (iSuccessCallback == null) {
            return;
        }
        MAIN_HANDLER.post(new Runnable() { // from class: com.gorilla.base.service.SystemSmsService$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                iSuccessCallback.onSuccess(str);
            }
        });
    }

    private static void fail(final IFailureCallback iFailureCallback, final int i, final String str) {
        if (iFailureCallback == null) {
            return;
        }
        MAIN_HANDLER.post(new Runnable() { // from class: com.gorilla.base.service.SystemSmsService$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                SystemSmsService.lambda$fail$1(iFailureCallback, i, str);
            }
        });
    }

    static /* synthetic */ void lambda$fail$1(IFailureCallback iFailureCallback, int i, String str) {
        if (str == null) {
            str = "Unknown error";
        }
        iFailureCallback.onFailure(i, str);
    }

    private static String buildPayload(String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, str);
            jSONObject.put("message", str2);
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    private static String optString(JSONObject jSONObject, String str) {
        String strOptString;
        return (jSONObject == null || (strOptString = jSONObject.optString(str, "")) == null) ? "" : strOptString;
    }
}
