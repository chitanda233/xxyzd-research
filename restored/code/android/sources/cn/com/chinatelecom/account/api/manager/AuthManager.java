package cn.com.chinatelecom.account.api.manager;

import android.content.Context;
import android.net.Network;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.CtSdkApi;
import cn.com.chinatelecom.account.api.CtSetting;
import cn.com.chinatelecom.account.api.ResultListener;
import cn.com.chinatelecom.account.api.encrypt.Xor;
import cn.com.chinatelecom.account.api.net.CtAuthNetworkRequest;
import cn.com.chinatelecom.account.api.net.DnsUtils;
import cn.com.chinatelecom.account.api.net.RequestConfig;
import cn.com.chinatelecom.account.api.net.ResponseInfo;
import cn.com.chinatelecom.account.api.utils.ApiUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.DeviceInfoUtil;
import cn.com.chinatelecom.account.api.utils.LogUtils;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import cn.com.chinatelecom.account.api.utils.ParamFactory;
import cn.com.chinatelecom.account.api.utils.ResultUtils;
import com.kuaishou.weapon.p0.t;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public final class AuthManager implements IAuth {
    private static final String TAG = "AuthManager";
    private String appId;
    private String appSecret;
    private Context context;
    private boolean isPreLoginTimeout = false;
    private SwitchNetManager switchNetManager;

    public AuthManager(Context context, String str, String str2) {
        this.context = context;
        this.appId = str;
        this.appSecret = str2;
    }

    @Override // cn.com.chinatelecom.account.api.manager.IAuth
    public void requestPreLogin4G(String str, CtSetting ctSetting, int i, ResultListener resultListener) {
        int totalTimeout = CtSetting.getTotalTimeout(ctSetting);
        String requestId = DeviceInfoUtil.getRequestId();
        String deviceId = DeviceInfoUtil.getDeviceId(this.context);
        String apiFlagByPreLogin = ApiUtils.getApiFlagByPreLogin(i);
        LogUtils.build(requestId).setDeviceId(deviceId).setApiFlag(apiFlagByPreLogin).setNetState(NetUtil.getNetState(this.context)).setOperatorType(NetUtil.getSimOperatorForLog(this.context));
        requestPreLogin(str, ctSetting, null, resultListener, totalTimeout, requestId, apiFlagByPreLogin, i);
    }

    @Override // cn.com.chinatelecom.account.api.manager.IAuth
    public void requestPreLoginBoth(final String str, final CtSetting ctSetting, final int i, final ResultListener resultListener) {
        final int totalTimeout = CtSetting.getTotalTimeout(ctSetting);
        final String requestId = DeviceInfoUtil.getRequestId();
        String deviceId = DeviceInfoUtil.getDeviceId(this.context);
        final String apiFlagByPreLogin = ApiUtils.getApiFlagByPreLogin(i);
        LogUtils.build(requestId).setDeviceId(deviceId).setApiFlag(apiFlagByPreLogin).setNetState("BOTH").setOperatorType(NetUtil.getSimOperatorForLog(this.context));
        SwitchNetManager switchNetManager = new SwitchNetManager(this.context);
        this.switchNetManager = switchNetManager;
        switchNetManager.switchToMobileNetV5(new SwitchCalllBack() { // from class: cn.com.chinatelecom.account.api.manager.AuthManager.1
            @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
            public void onSwitchSuccess(Network network, long j) {
                long j2 = ((long) totalTimeout) - j;
                if (j2 > 100) {
                    AuthManager.this.requestPreLogin(str, ctSetting, network, resultListener, j2, requestId, apiFlagByPreLogin, i);
                } else {
                    AuthManager.this.unregisterNetwork();
                    CtAuth.postResultOnMainThread(requestId, ResultUtils.getTimeoutException(), resultListener);
                }
                LogUtils.build(requestId).setSwitchTime(j);
            }

            @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
            public void onSwitchError(long j) {
                AuthManager.this.unregisterNetwork();
                AuthManager.this.setEroorResult(ResultUtils.CODE_SWITCH_EXCEPTION, Xor.de(ResultUtils.MSG_SWITCH_EXCEPTION), requestId, j, "", resultListener);
            }

            @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
            public void onSwitchTimeout() {
                AuthManager.this.unregisterNetwork();
                AuthManager.this.setEroorResult(ResultUtils.CODE_SWITCH_TIMEOUT, Xor.de(ResultUtils.MSG_SWITCH_TIMEOUT), requestId, 2500L, "", resultListener);
            }
        });
    }

    /* JADX INFO: renamed from: cn.com.chinatelecom.account.api.manager.AuthManager$2, reason: invalid class name */
    class AnonymousClass2 implements SwitchCalllBack {
        final /* synthetic */ String val$apiFlag;
        final /* synthetic */ int val$authType;
        final /* synthetic */ String val$bussinessType;
        final /* synthetic */ CtSetting val$ctSetting;
        final /* synthetic */ String val$reqId;
        final /* synthetic */ ResultListener val$resultListener;
        final /* synthetic */ int val$totalTimeout;

        AnonymousClass2(int i, String str, CtSetting ctSetting, ResultListener resultListener, String str2, String str3, int i2) {
            this.val$totalTimeout = i;
            this.val$bussinessType = str;
            this.val$ctSetting = ctSetting;
            this.val$resultListener = resultListener;
            this.val$reqId = str2;
            this.val$apiFlag = str3;
            this.val$authType = i2;
        }

        @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
        public void onSwitchSuccess(Network network, long j) {
            long j2 = ((long) this.val$totalTimeout) - j;
            if (j2 > 100) {
                AuthManager.this.requestPreLogin(this.val$bussinessType, this.val$ctSetting, null, this.val$resultListener, j2, this.val$reqId, this.val$apiFlag, this.val$authType);
            } else {
                CtAuth.postResultOnMainThread(this.val$reqId, ResultUtils.getTimeoutException(), this.val$resultListener);
            }
            LogUtils.build(this.val$reqId).setSwitchTime(j);
        }

        @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
        public void onSwitchError(long j) {
            AuthManager.this.setEroorResult(ResultUtils.CODE_SWITCH_EXCEPTION, Xor.de(ResultUtils.MSG_SWITCH_EXCEPTION), this.val$reqId, j, "Switching network failed (4.x)", this.val$resultListener);
        }

        @Override // cn.com.chinatelecom.account.api.manager.SwitchCalllBack
        public void onSwitchTimeout() {
            AuthManager.this.setEroorResult(ResultUtils.CODE_SWITCH_TIMEOUT, Xor.de(ResultUtils.MSG_SWITCH_TIMEOUT), this.val$reqId, 2500L, "Switching network timeout (4.x)", this.val$resultListener);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void unregisterNetwork() {
        SwitchNetManager switchNetManager = this.switchNetManager;
        if (switchNetManager != null) {
            switchNetManager.unregisterNetwork();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void requestPreLogin(final String str, final CtSetting ctSetting, final Network network, final ResultListener resultListener, long j, final String str2, final String str3, final int i) {
        new ThreadPoolManager().executeTask(new WorkTask(j) { // from class: cn.com.chinatelecom.account.api.manager.AuthManager.3
            @Override // cn.com.chinatelecom.account.api.manager.WorkTask
            public void runTask() {
                AuthManager authManager = AuthManager.this;
                JSONObject preMobile = authManager.getPreMobile(authManager.context, AuthManager.this.appId, AuthManager.this.appSecret, str, ctSetting, network, str2, str3, i);
                synchronized (this) {
                    if (!isCompleted()) {
                        setCompleted(true);
                        removeTimeoutTask();
                        CtAuth.postResultOnMainThread(str2, preMobile, resultListener);
                    }
                }
                if (network != null) {
                    AuthManager.this.unregisterNetwork();
                }
            }

            @Override // cn.com.chinatelecom.account.api.manager.WorkTask
            public void timeout() {
                super.timeout();
                synchronized (AuthManager.this) {
                    AuthManager.this.isPreLoginTimeout = true;
                }
                synchronized (this) {
                    if (!isCompleted()) {
                        setCompleted(true);
                        AuthManager.this.setEroorResult(80000, Xor.de(ResultUtils.MSG_TIMEOUT_EXCEPTION), str2, 0L, "", resultListener);
                    }
                }
                if (network != null) {
                    AuthManager.this.unregisterNetwork();
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public JSONObject getPreMobile(Context context, String str, String str2, String str3, CtSetting ctSetting, Network network, String str4, String str5, int i) {
        String preBiomLoginUrl;
        String preBiomLoginParams;
        boolean z;
        try {
            long timeDiff = ApiUtils.getTimeDiff(context);
            if (i == CtSdkApi.AUTH_ONEKEY) {
                preBiomLoginUrl = NetUtil.getPreLoginUrlNew(context);
                preBiomLoginParams = ParamFactory.getPreLoginParams(context, str, str2, str3, timeDiff, "");
            } else {
                preBiomLoginUrl = ParamFactory.getPreBiomLoginUrl();
                preBiomLoginParams = ParamFactory.getPreBiomLoginParams(context, str, str2, str3, timeDiff, "");
            }
            if (NetUtil.getPreLoginDomainName() != null) {
                preBiomLoginUrl = preBiomLoginUrl.replace(Xor.de(Constants.paramsId6Domain), NetUtil.getPreLoginDomainName());
            }
            String str6 = preBiomLoginUrl;
            JSONObject jSONObject = new JSONObject(preBiomLoginParams);
            String strOptString = jSONObject.optString(t.b);
            String strOptString2 = jSONObject.optString(t.f2732a);
            RequestConfig.Builder builder = new RequestConfig.Builder();
            builder.setApiFlag(str5);
            builder.setIpConnect(false, DnsUtils.getPreLoginIpv4Addr(), Xor.de(Constants.paramsId6Domain));
            builder.setRequestId(str4);
            builder.setNetwork(network);
            builder.setConnetTimeout(CtSetting.getConnTimeout(ctSetting));
            builder.setReadTimeout(CtSetting.getReadTimeout(ctSetting));
            RequestConfig requestConfigBuild = builder.build();
            CtAuthNetworkRequest ctAuthNetworkRequest = new CtAuthNetworkRequest(context);
            ResponseInfo responseInfoSendRequest = ctAuthNetworkRequest.sendRequest(str6, strOptString, 1, requestConfigBuild, true);
            if (responseInfoSendRequest.retryPreLogin) {
                synchronized (this) {
                    z = this.isPreLoginTimeout;
                }
                if (!z) {
                    RequestConfig requestConfigBuild2 = builder.setRetry(true).setIpConnect(false, "", "").build();
                    String preLoginUrl = ParamFactory.getPreLoginUrl();
                    if (responseInfoSendRequest.retryPreLoginType.equals("2")) {
                        preLoginUrl = preLoginUrl.replace(Xor.de(Constants.paramsId6Domain), Xor.de(Constants.paramsCardDomain));
                    }
                    ResponseInfo responseInfoSendRequest2 = ctAuthNetworkRequest.sendRequest(preLoginUrl, strOptString, 1, requestConfigBuild2, false);
                    LogUtils.build(str4).setRetryCount(1).setNetState(NetUtil.getNetStateForLog(context));
                    responseInfoSendRequest = responseInfoSendRequest2;
                }
            }
            JSONObject preCodeResult = ApiUtils.parsePreCodeResult(context, responseInfoSendRequest, strOptString2, network, true, str4);
            LogUtils.setResultAndMsg(str4, preCodeResult, strOptString);
            return preCodeResult;
        } catch (Throwable th) {
            JSONObject preloginExceptionJson = ResultUtils.getPreloginExceptionJson();
            LogUtils.build(str4).putException("gpm ：" + th.getMessage()).setNetState(NetUtil.getNetStateForLog(context)).setResult(ResultUtils.CODE_PRELOGIN_EXCEPTION).setMsg(Xor.de(ResultUtils.MSG_PRELOGIN_EXCEPTION));
            CtAuth.warn(TAG, "GPM Throwable", th);
            return preloginExceptionJson;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void setEroorResult(int i, String str, String str2, long j, String str3, ResultListener resultListener) {
        LogUtils.build(str2).setResult(i).setMsg(str).setSwitchTime(j).putException(str3).setNetState(NetUtil.getNetStateForLog(this.context));
        LogUtils.upload(str2);
        String result = ResultUtils.toResult(i, str, str2);
        if (resultListener != null) {
            resultListener.onResult(result);
        }
    }
}
