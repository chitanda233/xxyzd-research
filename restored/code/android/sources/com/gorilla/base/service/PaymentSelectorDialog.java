package com.gorilla.base.service;

import android.app.Dialog;
import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.RadioButton;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.gorilla.base.R;
import java.text.DecimalFormat;

/* JADX INFO: loaded from: classes3.dex */
final class PaymentSelectorDialog extends Dialog implements View.OnClickListener {
    static final int ALIPAY_PAY = 1;
    static final int WECHAT_PAY = 0;
    private RelativeLayout aliPayLayout;
    private RadioButton aliPayRadio;
    private TextView cancelView;
    private TextView confirmButton;
    private boolean hasHandledResult;
    private final Listener listener;
    private double payMoney;
    private TextView payMoneyView;
    private int payType;
    private final DecimalFormat priceFormat;
    private boolean showAliPay;
    private boolean showWeChat;
    private RelativeLayout weChatLayout;
    private RadioButton weChatRadio;

    interface Listener {
        void onCancel();

        void onConfirm(int i);
    }

    PaymentSelectorDialog(Context context, Listener listener) {
        super(context, R.style.GorillaPayListActionSheetDialogStyle);
        this.priceFormat = new DecimalFormat("0.00");
        this.showWeChat = true;
        this.showAliPay = true;
        this.payType = 0;
        this.listener = listener;
    }

    PaymentSelectorDialog setPayMoney(double d) {
        this.payMoney = d;
        return this;
    }

    PaymentSelectorDialog setDefaultPayType(int i) {
        this.payType = i;
        return this;
    }

    PaymentSelectorDialog setShowWeChat(boolean z) {
        this.showWeChat = z;
        return this;
    }

    PaymentSelectorDialog setShowAliPay(boolean z) {
        this.showAliPay = z;
        return this;
    }

    @Override // android.app.Dialog
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setContentView(R.layout.gorilla_paylist_dialog_layout);
        this.cancelView = (TextView) findViewById(R.id.gorilla_paylist_cancel);
        this.payMoneyView = (TextView) findViewById(R.id.gorilla_paylist_amount);
        this.weChatLayout = (RelativeLayout) findViewById(R.id.gorilla_paylist_wechat_row);
        this.aliPayLayout = (RelativeLayout) findViewById(R.id.gorilla_paylist_alipay_row);
        this.weChatRadio = (RadioButton) findViewById(R.id.gorilla_paylist_wechat_radio);
        this.aliPayRadio = (RadioButton) findViewById(R.id.gorilla_paylist_alipay_radio);
        this.confirmButton = (TextView) findViewById(R.id.gorilla_paylist_confirm_button);
        this.cancelView.setOnClickListener(this);
        this.weChatLayout.setOnClickListener(this);
        this.aliPayLayout.setOnClickListener(this);
        this.confirmButton.setOnClickListener(this);
        this.payMoneyView.setText(this.priceFormat.format(this.payMoney));
        bindChannelVisibility();
        bindDefaultSelection();
    }

    @Override // android.app.Dialog
    public void show() {
        super.show();
        Window window = getWindow();
        if (window == null) {
            return;
        }
        WindowManager.LayoutParams attributes = window.getAttributes();
        attributes.width = -1;
        attributes.height = -2;
        window.setAttributes(attributes);
        window.setGravity(80);
        setCanceledOnTouchOutside(true);
    }

    @Override // android.app.Dialog, android.content.DialogInterface
    public void dismiss() {
        Listener listener;
        if (!this.hasHandledResult && (listener = this.listener) != null) {
            this.hasHandledResult = true;
            listener.onCancel();
        }
        super.dismiss();
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        int id = view.getId();
        if (id == R.id.gorilla_paylist_wechat_row) {
            selectPayType(0);
            return;
        }
        if (id == R.id.gorilla_paylist_alipay_row) {
            selectPayType(1);
            return;
        }
        if (id == R.id.gorilla_paylist_confirm_button) {
            this.hasHandledResult = true;
            Listener listener = this.listener;
            if (listener != null) {
                listener.onConfirm(this.payType);
            }
            super.dismiss();
            return;
        }
        if (id == R.id.gorilla_paylist_cancel) {
            this.hasHandledResult = true;
            Listener listener2 = this.listener;
            if (listener2 != null) {
                listener2.onCancel();
            }
            super.dismiss();
        }
    }

    private void bindChannelVisibility() {
        this.weChatLayout.setVisibility(this.showWeChat ? 0 : 8);
        this.aliPayLayout.setVisibility(this.showAliPay ? 0 : 8);
    }

    private void bindDefaultSelection() {
        boolean z = this.showWeChat;
        if (!z && this.showAliPay) {
            selectPayType(1);
        } else if (z && !this.showAliPay) {
            selectPayType(0);
        } else {
            selectPayType(this.payType);
        }
    }

    private void selectPayType(int i) {
        this.payType = i;
        this.weChatRadio.setChecked(i == 0);
        this.aliPayRadio.setChecked(i == 1);
    }
}
