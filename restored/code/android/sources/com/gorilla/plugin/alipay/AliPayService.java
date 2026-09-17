package com.gorilla.plugin.alipay;

import android.app.Activity;
import android.text.TextUtils;
import com.alipay.sdk.app.AlipayApi;
import com.alipay.sdk.app.EnvUtils;
import com.alipay.sdk.app.PayTask;
import com.alipay.sdk.m.y.o;
import com.gorilla.base.GorillaContext;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.service.MetaDataService;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class AliPayService {
    private static final String META_APP_ID = "gorillaAliPayAppId";
    private static final String META_APP_ID_PREFIX = "gorilla_alipay_app_id:";
    private static final String META_IS_SANDBOX = "gorillaAliPaySandbox";
    private static final String RESULT_STATUS_CANCEL = "6001";
    private static final String RESULT_STATUS_SUCCESS = "9000";
    private static final String TAG = "[AliPayService]";
    private static final AliPayService instance = new AliPayService();
    private String appId;
    private final ILogger logger = LogFactory.getLogger();

    public static AliPayService getInstance() {
        return instance;
    }

    private AliPayService() {
    }

    public void init() {
        String strNormalizeAppId = normalizeAppId(MetaDataService.getMetaData(META_APP_ID, ""));
        this.appId = strNormalizeAppId;
        if (TextUtils.isEmpty(strNormalizeAppId)) {
            this.logger.warning(TAG, "Please set Alipay App ID to AndroidManifest metadata for key: gorillaAliPayAppId");
            return;
        }
        this.logger.log(TAG, "Alipay configure with appId: " + this.appId);
        Activity activity = GorillaContext.getInstance().getActivity();
        if (activity == null) {
            this.logger.warning(TAG, "Activity is null");
            return;
        }
        if (MetaDataService.getMetaData(META_IS_SANDBOX, false)) {
            this.logger.warning(TAG, "AliPay SDK is in sandbox mode");
            EnvUtils.setEnv(EnvUtils.EnvEnum.SANDBOX);
        }
        this.logger.log(TAG, "Alipay version: " + getVersion(activity));
        AlipayApi.registerApp(activity, this.appId);
    }

    private String normalizeAppId(String str) {
        if (TextUtils.isEmpty(str)) {
            return "";
        }
        return str.startsWith(META_APP_ID_PREFIX) ? str.substring(22) : str;
    }

    public String getVersion(Activity activity) {
        if (activity == null) {
            return "";
        }
        try {
            return new PayTask(activity).getVersion();
        } catch (Exception e) {
            this.logger.error(TAG, "Failed to get Alipay SDK version: " + e.getMessage());
            return "";
        }
    }

    public void purchase(final Activity activity, JSONObject jSONObject, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback, final ICancelCallback iCancelCallback) {
        if (TextUtils.isEmpty(this.appId)) {
            fail(iFailureCallback, -1, "AliPay SDK not configured");
            return;
        }
        if (activity == null) {
            fail(iFailureCallback, -1, "Activity is null");
            return;
        }
        if (jSONObject == null) {
            fail(iFailureCallback, -1, "Order string is missing.");
            return;
        }
        final String strOptString = jSONObject.optString("orderString", "");
        if (TextUtils.isEmpty(strOptString)) {
            fail(iFailureCallback, -1, "Order string is missing.");
        } else {
            new Thread(new Runnable() { // from class: com.gorilla.plugin.alipay.AliPayService$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.m150lambda$purchase$0$comgorillapluginalipayAliPayService(activity, strOptString, iSuccessCallback, iFailureCallback, iCancelCallback);
                }
            }, "GorillaAliPay").start();
        }
    }

    /* JADX INFO: renamed from: lambda$purchase$0$com-gorilla-plugin-alipay-AliPayService, reason: not valid java name */
    /* synthetic */ void m150lambda$purchase$0$comgorillapluginalipayAliPayService(Activity activity, String str, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        try {
            handlePaymentResult(new PayTask(activity).payV2(str, true), iSuccessCallback, iFailureCallback, iCancelCallback);
        } catch (Exception e) {
            this.logger.error(TAG, "AliPay payment error: " + e.getMessage());
            fail(iFailureCallback, -1, e.getMessage());
        }
    }

    private void handlePaymentResult(Map<String, String> map, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        JSONObject jSONObjectBuildResultPayload = buildResultPayload(map);
        String strOptString = jSONObjectBuildResultPayload.optString(o.f393a, "");
        String strOptString2 = jSONObjectBuildResultPayload.optString(o.b, "");
        this.logger.log(TAG, "AliPay payment result: " + jSONObjectBuildResultPayload);
        if (RESULT_STATUS_SUCCESS.equals(strOptString)) {
            if (iSuccessCallback != null) {
                iSuccessCallback.onSuccess(jSONObjectBuildResultPayload.toString());
            }
        } else if (!RESULT_STATUS_CANCEL.equals(strOptString)) {
            fail(iFailureCallback, parseResultStatus(strOptString), strOptString2);
        } else if (iCancelCallback != null) {
            iCancelCallback.onCancel();
        }
    }

    private JSONObject buildResultPayload(Map<String, String> map) {
        JSONObject jSONObject = new JSONObject();
        if (map == null) {
            return jSONObject;
        }
        try {
            jSONObject.put(o.f393a, getResultValue(map, o.f393a));
            jSONObject.put(o.b, getResultValue(map, o.b));
            jSONObject.put(o.c, getResultValue(map, o.c));
        } catch (Exception e) {
            this.logger.error(TAG, "Failed to build AliPay result payload: " + e.getMessage());
        }
        return jSONObject;
    }

    private String getResultValue(Map<String, String> map, String str) {
        String str2 = map.get(str);
        return str2 == null ? "" : str2;
    }

    private int parseResultStatus(String str) {
        try {
            return Integer.parseInt(str);
        } catch (Exception unused) {
            return -1;
        }
    }

    private void fail(IFailureCallback iFailureCallback, int i, String str) {
        this.logger.error(TAG, "AliPay failed, code: " + i + ", message: " + str);
        if (iFailureCallback != null) {
            if (str == null) {
                str = "";
            }
            iFailureCallback.onFailure(i, str);
        }
    }
}
