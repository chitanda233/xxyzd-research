package com.gorilla.base.model;

import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class PaymentSelectorArgs {
    private static final int ALIPAY_PAY = 1;
    public static final String CHANNEL_ALIPAY = "AliPay";
    public static final String CHANNEL_WECHAT = "WeChat";
    private static final int WECHAT_PAY = 0;
    public final int defaultPayType;
    public final double payMoney;
    public final boolean showAliPay;
    public final boolean showWeChat;

    private PaymentSelectorArgs(double d, int i, boolean z, boolean z2) {
        this.payMoney = d;
        this.defaultPayType = i;
        this.showWeChat = z;
        this.showAliPay = z2;
    }

    public static PaymentSelectorArgs fromJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        double dOptLong = jSONObject.optLong("amountFen", 0L) / 100.0d;
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("showList");
        if (jSONArrayOptJSONArray == null || jSONArrayOptJSONArray.length() == 0) {
            throw new IllegalArgumentException("showList is required.");
        }
        boolean z = false;
        boolean z2 = false;
        int i = -1;
        for (int i2 = 0; i2 < jSONArrayOptJSONArray.length(); i2++) {
            String strOptString = jSONArrayOptJSONArray.optString(i2, "");
            if (isWeChatChannel(strOptString)) {
                if (i < 0) {
                    i = 0;
                }
                z = true;
            } else {
                if (!isAliPayChannel(strOptString)) {
                    throw new IllegalArgumentException("Unsupported channel: " + strOptString);
                }
                if (i < 0) {
                    i = 1;
                    z2 = true;
                } else {
                    z2 = true;
                }
            }
        }
        if (i < 0) {
            throw new IllegalArgumentException("showList has no supported channel.");
        }
        return new PaymentSelectorArgs(dOptLong, i, z, z2);
    }

    private static boolean isWeChatChannel(String str) {
        return CHANNEL_WECHAT.equalsIgnoreCase(str);
    }

    private static boolean isAliPayChannel(String str) {
        return CHANNEL_ALIPAY.equalsIgnoreCase(str);
    }
}
