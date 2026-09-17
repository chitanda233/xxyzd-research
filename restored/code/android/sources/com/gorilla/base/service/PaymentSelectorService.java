package com.gorilla.base.service;

import android.app.Activity;
import android.os.Handler;
import android.os.Looper;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.model.PaymentSelectorArgs;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class PaymentSelectorService {
    private static final Handler MAIN_HANDLER = new Handler(Looper.getMainLooper());
    private static final String TAG = "[PaymentSelectorService]";

    private PaymentSelectorService() {
    }

    public static void show(final Activity activity, JSONObject jSONObject, final ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, final ICancelCallback iCancelCallback) {
        if (activity == null) {
            fail(iFailureCallback, -1, "Activity is null.");
            return;
        }
        try {
            final PaymentSelectorArgs paymentSelectorArgsFromJson = PaymentSelectorArgs.fromJson(jSONObject);
            MAIN_HANDLER.post(new Runnable() { // from class: com.gorilla.base.service.PaymentSelectorService$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    Activity activity2 = activity;
                    ISuccessCallback iSuccessCallback2 = iSuccessCallback;
                    ICancelCallback iCancelCallback2 = iCancelCallback;
                    PaymentSelectorArgs paymentSelectorArgs = paymentSelectorArgsFromJson;
                    new PaymentSelectorDialog(activity2, new PaymentSelectorDialog.Listener() { // from class: com.gorilla.base.service.PaymentSelectorService.1
                        @Override // com.gorilla.base.service.PaymentSelectorDialog.Listener
                        public void onConfirm(int i) {
                            ISuccessCallback iSuccessCallback3 = iSuccessCallback2;
                            if (iSuccessCallback3 != null) {
                                if (i == 1) {
                                    iSuccessCallback3.onSuccess(PaymentSelectorArgs.CHANNEL_ALIPAY);
                                } else {
                                    iSuccessCallback3.onSuccess(PaymentSelectorArgs.CHANNEL_WECHAT);
                                }
                            }
                        }

                        @Override // com.gorilla.base.service.PaymentSelectorDialog.Listener
                        public void onCancel() {
                            ICancelCallback iCancelCallback3 = iCancelCallback2;
                            if (iCancelCallback3 != null) {
                                iCancelCallback3.onCancel();
                            }
                        }
                    }).setPayMoney(paymentSelectorArgs.payMoney).setShowWeChat(paymentSelectorArgs.showWeChat).setShowAliPay(paymentSelectorArgs.showAliPay).setDefaultPayType(paymentSelectorArgs.defaultPayType).show();
                }
            });
        } catch (Exception e) {
            LogFactory.getLogger().error(TAG, "Failed to parse showPayList args: " + e.getMessage());
            fail(iFailureCallback, -1, "Failed to parse showPayList args.");
        }
    }

    private static void fail(final IFailureCallback iFailureCallback, final int i, final String str) {
        if (iFailureCallback == null) {
            return;
        }
        MAIN_HANDLER.post(new Runnable() { // from class: com.gorilla.base.service.PaymentSelectorService$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                iFailureCallback.onFailure(i, str);
            }
        });
    }
}
