package com.gorilla.base.service;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.net.Uri;
import android.text.SpannableString;
import android.text.TextPaint;
import android.text.method.LinkMovementMethod;
import android.text.style.ClickableSpan;
import android.view.View;
import android.widget.TextView;
import com.alipay.sdk.m.c0.d;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.gorilla.base.Api;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class PrivacyPolicyService {
    private static final String TAG = "[PrivacyPolicyService]";
    private static AlertDialog currentDialog;

    private PrivacyPolicyService() {
    }

    public static void show(Activity activity, JSONObject jSONObject, final ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, final ICancelCallback iCancelCallback) {
        if (activity == null || activity.isFinishing()) {
            fail(iFailureCallback, "Activity is unavailable.");
            return;
        }
        if (jSONObject == null) {
            fail(iFailureCallback, "Privacy policy arguments are required.");
            return;
        }
        AlertDialog alertDialog = currentDialog;
        if (alertDialog != null && alertDialog.isShowing()) {
            Api.logger.log(TAG, "Privacy policy dialog is already showing. Ignoring duplicate request.");
            return;
        }
        try {
            String strOptString = jSONObject.optString(d.w, "");
            String strOptString2 = jSONObject.optString(IAdInterListener.AdProdType.PRODUCT_CONTENT, "");
            String strOptString3 = jSONObject.optString("confirmButtonText", "");
            String strOptString4 = jSONObject.optString("cancelButtonText", "");
            boolean zOptBoolean = jSONObject.optBoolean("showCancelButton", false);
            SpannableString spannableString = new SpannableString(strOptString2);
            applyLink(activity, spannableString, jSONObject.optJSONObject("serviceTermsLink"));
            applyLink(activity, spannableString, jSONObject.optJSONObject("privacyPolicyLink"));
            TextView textView = new TextView(activity);
            int iDp = dp(activity, 24);
            int iDp2 = dp(activity, 8);
            textView.setPadding(iDp, iDp2, iDp, iDp2);
            textView.setText(spannableString);
            textView.setTextSize(16.0f);
            textView.setLineSpacing(0.0f, 1.15f);
            textView.setMovementMethod(LinkMovementMethod.getInstance());
            textView.setHighlightColor(0);
            textView.setVerticalScrollBarEnabled(true);
            final AtomicBoolean atomicBoolean = new AtomicBoolean(false);
            AlertDialog.Builder cancelable = new AlertDialog.Builder(activity).setTitle(strOptString).setView(textView).setPositiveButton(strOptString3, new DialogInterface.OnClickListener() { // from class: com.gorilla.base.service.PrivacyPolicyService$$ExternalSyntheticLambda0
                @Override // android.content.DialogInterface.OnClickListener
                public final void onClick(DialogInterface dialogInterface, int i) {
                    PrivacyPolicyService.lambda$show$0(atomicBoolean, iSuccessCallback, dialogInterface, i);
                }
            }).setCancelable(zOptBoolean);
            if (zOptBoolean) {
                cancelable.setNegativeButton(strOptString4, new DialogInterface.OnClickListener() { // from class: com.gorilla.base.service.PrivacyPolicyService$$ExternalSyntheticLambda1
                    @Override // android.content.DialogInterface.OnClickListener
                    public final void onClick(DialogInterface dialogInterface, int i) {
                        PrivacyPolicyService.lambda$show$1(atomicBoolean, iCancelCallback, dialogInterface, i);
                    }
                });
                cancelable.setOnCancelListener(new DialogInterface.OnCancelListener() { // from class: com.gorilla.base.service.PrivacyPolicyService$$ExternalSyntheticLambda2
                    @Override // android.content.DialogInterface.OnCancelListener
                    public final void onCancel(DialogInterface dialogInterface) {
                        PrivacyPolicyService.lambda$show$2(atomicBoolean, iCancelCallback, dialogInterface);
                    }
                });
            }
            final AlertDialog alertDialogCreate = cancelable.create();
            currentDialog = alertDialogCreate;
            alertDialogCreate.setCanceledOnTouchOutside(false);
            alertDialogCreate.setOnDismissListener(new DialogInterface.OnDismissListener() { // from class: com.gorilla.base.service.PrivacyPolicyService$$ExternalSyntheticLambda3
                @Override // android.content.DialogInterface.OnDismissListener
                public final void onDismiss(DialogInterface dialogInterface) {
                    PrivacyPolicyService.lambda$show$3(alertDialogCreate, dialogInterface);
                }
            });
            alertDialogCreate.show();
            if (iSuccessCallback != null) {
                iSuccessCallback.onSuccess(eventPayload("presented"));
            }
        } catch (Exception e) {
            currentDialog = null;
            fail(iFailureCallback, e.getMessage());
        }
    }

    static /* synthetic */ void lambda$show$0(AtomicBoolean atomicBoolean, ISuccessCallback iSuccessCallback, DialogInterface dialogInterface, int i) {
        if (!atomicBoolean.compareAndSet(false, true) || iSuccessCallback == null) {
            return;
        }
        iSuccessCallback.onSuccess(eventPayload("confirmed"));
    }

    static /* synthetic */ void lambda$show$1(AtomicBoolean atomicBoolean, ICancelCallback iCancelCallback, DialogInterface dialogInterface, int i) {
        if (!atomicBoolean.compareAndSet(false, true) || iCancelCallback == null) {
            return;
        }
        iCancelCallback.onCancel();
    }

    static /* synthetic */ void lambda$show$2(AtomicBoolean atomicBoolean, ICancelCallback iCancelCallback, DialogInterface dialogInterface) {
        if (!atomicBoolean.compareAndSet(false, true) || iCancelCallback == null) {
            return;
        }
        iCancelCallback.onCancel();
    }

    static /* synthetic */ void lambda$show$3(AlertDialog alertDialog, DialogInterface dialogInterface) {
        if (currentDialog == alertDialog) {
            currentDialog = null;
        }
    }

    private static void applyLink(final Activity activity, SpannableString spannableString, JSONObject jSONObject) throws JSONException {
        if (jSONObject == null) {
            throw new JSONException("Privacy policy link is required.");
        }
        int i = jSONObject.getInt("start");
        int i2 = jSONObject.getInt("length");
        final String string = jSONObject.getString("url");
        int i3 = i + i2;
        if (i < 0 || i2 <= 0 || i3 > spannableString.length()) {
            throw new JSONException("Privacy policy link range is invalid.");
        }
        spannableString.setSpan(new ClickableSpan() { // from class: com.gorilla.base.service.PrivacyPolicyService.1
            @Override // android.text.style.ClickableSpan
            public void onClick(View view) {
                try {
                    activity.startActivity(new Intent("android.intent.action.VIEW", Uri.parse(string)));
                } catch (Exception e) {
                    Api.logger.error(PrivacyPolicyService.TAG, "Failed to open privacy policy URL: " + e.getMessage());
                }
            }

            @Override // android.text.style.ClickableSpan, android.text.style.CharacterStyle
            public void updateDrawState(TextPaint textPaint) {
                super.updateDrawState(textPaint);
                textPaint.setUnderlineText(true);
            }
        }, i, i3, 33);
    }

    private static int dp(Activity activity, int i) {
        return Math.round(i * activity.getResources().getDisplayMetrics().density);
    }

    private static String eventPayload(String str) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("eventName", str);
        } catch (JSONException unused) {
        }
        return jSONObject.toString();
    }

    private static void fail(IFailureCallback iFailureCallback, String str) {
        if (iFailureCallback != null) {
            if (str == null) {
                str = "Failed to show privacy policy.";
            }
            iFailureCallback.onFailure(-1, str);
        }
    }
}
