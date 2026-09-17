package com.bytedance.ads.convert.event;

import com.bytedance.ads.convert.flat.f.b;
import com.qq.gdt.action.ActionUtils;
import kotlin.Metadata;
import kotlin.jvm.JvmStatic;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@Metadata(bv = {1, 0, 3}, d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0014\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b \u0010!J+\u0010\t\u001a\u00020\b2\u0006\u0010\u0003\u001a\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u00042\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0007¢\u0006\u0004\b\t\u0010\nJg\u0010\u0014\u001a\u00020\b2\u0006\u0010\u000b\u001a\u00020\u00022\u0006\u0010\f\u001a\u00020\u00022\u0006\u0010\r\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u00022\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u00042\u0006\u0010\u0012\u001a\u00020\u000e2\n\b\u0002\u0010\u0013\u001a\u0004\u0018\u00010\u00022\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0007¢\u0006\u0004\b\u0014\u0010\u0015J+\u0010\u0017\u001a\u00020\b2\u0006\u0010\u0016\u001a\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u00042\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0007¢\u0006\u0004\b\u0017\u0010\nJ#\u0010\u0019\u001a\u00020\b2\u0006\u0010\u0018\u001a\u00020\u000e2\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0007¢\u0006\u0004\b\u0019\u0010\u001aJ#\u0010\u001c\u001a\u00020\b2\u0006\u0010\u001b\u001a\u00020\u00022\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0007¢\u0006\u0004\b\u001c\u0010\u001dJ\u001f\u0010\u001f\u001a\u00020\b2\u0006\u0010\u001e\u001a\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0006H\u0007¢\u0006\u0004\b\u001f\u0010\u001d¨\u0006\""}, d2 = {"Lcom/bytedance/ads/convert/event/ConvertReportHelper;", "", "", "registerMethod", "", "isSuccess", "Lorg/json/JSONObject;", "extraParams", "", "onEventRegister", "(Ljava/lang/String;ZLorg/json/JSONObject;)V", "contentType", "contentName", "contentId", "", "contentNumber", "paymentChannel", "currency", "currencyAmount", "ttOpenId", "onEventPurchase", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;ZILjava/lang/String;Lorg/json/JSONObject;)V", "method", "onLoginEvent", ActionUtils.LEVEL, "onUpdateLevelEvent", "(ILorg/json/JSONObject;)V", "gameroleId", "onCreateGameRoleEvent", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "eventName", "onEventV3", "<init>", "()V", "convert_release"}, k = 1, mv = {1, 4, 0})
public final class ConvertReportHelper {
    public static final ConvertReportHelper INSTANCE = new ConvertReportHelper();

    private ConvertReportHelper() {
    }

    @JvmStatic
    public static final void onCreateGameRoleEvent(String str) throws JSONException {
        onCreateGameRoleEvent$default(str, null, 2, null);
    }

    @JvmStatic
    public static final void onCreateGameRoleEvent(String gameroleId, JSONObject extraParams) throws JSONException {
        Intrinsics.checkNotNullParameter(gameroleId, "gameroleId");
        if (extraParams == null) {
            extraParams = new JSONObject();
        }
        extraParams.put("gamerole_id", gameroleId);
        onEventV3("create_gamerole", extraParams);
    }

    public static /* synthetic */ void onCreateGameRoleEvent$default(String str, JSONObject jSONObject, int i, Object obj) throws JSONException {
        if ((i & 2) != 0) {
            jSONObject = null;
        }
        onCreateGameRoleEvent(str, jSONObject);
    }

    @JvmStatic
    public static final void onEventPurchase(String str, String str2, String str3, int i, String str4, String str5, boolean z, int i2) throws JSONException {
        onEventPurchase$default(str, str2, str3, i, str4, str5, z, i2, null, null, 768, null);
    }

    @JvmStatic
    public static final void onEventPurchase(String str, String str2, String str3, int i, String str4, String str5, boolean z, int i2, String str6) throws JSONException {
        onEventPurchase$default(str, str2, str3, i, str4, str5, z, i2, str6, null, 512, null);
    }

    @JvmStatic
    public static final void onEventPurchase(String contentType, String contentName, String contentId, int contentNumber, String paymentChannel, String currency, boolean isSuccess, int currencyAmount, String ttOpenId, JSONObject extraParams) throws JSONException {
        Intrinsics.checkNotNullParameter(contentType, "contentType");
        Intrinsics.checkNotNullParameter(contentName, "contentName");
        Intrinsics.checkNotNullParameter(contentId, "contentId");
        Intrinsics.checkNotNullParameter(paymentChannel, "paymentChannel");
        Intrinsics.checkNotNullParameter(currency, "currency");
        if (extraParams == null) {
            extraParams = new JSONObject();
        }
        extraParams.put(ActionUtils.CONTENT_TYPE, contentType);
        extraParams.put(ActionUtils.CONTENT_NAME, contentName);
        extraParams.put(ActionUtils.CONTENT_ID, contentId);
        extraParams.put("content_num", contentNumber);
        extraParams.put(ActionUtils.PAYMENT_CHANNEL, paymentChannel);
        extraParams.put("currency", currency);
        extraParams.put(ActionUtils.IS_SUCCESS, isSuccess ? "yes" : "no");
        extraParams.put("currency_amount", currencyAmount);
        extraParams.put("tt_open_id", ttOpenId);
        onEventV3("purchase", extraParams);
    }

    public static /* synthetic */ void onEventPurchase$default(String str, String str2, String str3, int i, String str4, String str5, boolean z, int i2, String str6, JSONObject jSONObject, int i3, Object obj) throws JSONException {
        onEventPurchase(str, str2, str3, i, str4, str5, z, i2, (i3 & 256) != 0 ? null : str6, (i3 & 512) != 0 ? null : jSONObject);
    }

    @JvmStatic
    public static final void onEventRegister(String str, boolean z) throws JSONException {
        onEventRegister$default(str, z, null, 4, null);
    }

    @JvmStatic
    public static final void onEventRegister(String registerMethod, boolean isSuccess, JSONObject extraParams) throws JSONException {
        Intrinsics.checkNotNullParameter(registerMethod, "registerMethod");
        if (extraParams == null) {
            extraParams = new JSONObject();
        }
        extraParams.put("method", registerMethod);
        extraParams.put(ActionUtils.IS_SUCCESS, isSuccess);
        onEventV3("register", extraParams);
    }

    public static /* synthetic */ void onEventRegister$default(String str, boolean z, JSONObject jSONObject, int i, Object obj) throws JSONException {
        if ((i & 4) != 0) {
            jSONObject = null;
        }
        onEventRegister(str, z, jSONObject);
    }

    @JvmStatic
    public static final void onEventV3(String eventName, JSONObject extraParams) {
        Intrinsics.checkNotNullParameter(eventName, "eventName");
        Intrinsics.checkNotNullParameter(extraParams, "extraParams");
        Intrinsics.checkNotNullParameter(eventName, "label");
        Intrinsics.checkNotNullParameter(extraParams, "params");
        b bVar = new b(eventName);
        bVar.g = null;
        bVar.h = extraParams;
        bVar.a("Convert:" + eventName);
    }

    @JvmStatic
    public static final void onLoginEvent(String str, boolean z) throws JSONException {
        onLoginEvent$default(str, z, null, 4, null);
    }

    @JvmStatic
    public static final void onLoginEvent(String method, boolean isSuccess, JSONObject extraParams) throws JSONException {
        Intrinsics.checkNotNullParameter(method, "method");
        if (extraParams == null) {
            extraParams = new JSONObject();
        }
        String str = !isSuccess ? "no" : "yes";
        extraParams.put("method", method);
        extraParams.put(ActionUtils.IS_SUCCESS, str);
        onEventV3("log_in", extraParams);
    }

    public static /* synthetic */ void onLoginEvent$default(String str, boolean z, JSONObject jSONObject, int i, Object obj) throws JSONException {
        if ((i & 4) != 0) {
            jSONObject = null;
        }
        onLoginEvent(str, z, jSONObject);
    }

    @JvmStatic
    public static final void onUpdateLevelEvent(int i) throws JSONException {
        onUpdateLevelEvent$default(i, null, 2, null);
    }

    @JvmStatic
    public static final void onUpdateLevelEvent(int level, JSONObject extraParams) throws JSONException {
        if (extraParams == null) {
            extraParams = new JSONObject();
        }
        extraParams.put(ActionUtils.LEVEL, level);
        onEventV3("update_level", extraParams);
    }

    public static /* synthetic */ void onUpdateLevelEvent$default(int i, JSONObject jSONObject, int i2, Object obj) throws JSONException {
        if ((i2 & 2) != 0) {
            jSONObject = null;
        }
        onUpdateLevelEvent(i, jSONObject);
    }
}
