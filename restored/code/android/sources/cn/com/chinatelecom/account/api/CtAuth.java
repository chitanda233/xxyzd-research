package cn.com.chinatelecom.account.api;

import android.app.Application;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.encrypt.Xor;
import cn.com.chinatelecom.account.api.manager.AuthManager;
import cn.com.chinatelecom.account.api.net.DnsUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.LogUtils;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import cn.com.chinatelecom.account.api.utils.ResultUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class CtAuth {
    private static final String TAG = "CtAuth";
    private static volatile CtAuth instance = null;
    public static boolean isInit = false;
    public static String mAppId = "";
    public static String mAppSecret = "";
    public static Context mContext;
    public static Handler mHandler = new Handler(Looper.getMainLooper());
    public static TraceLogger mTraceLogger;

    public static CtAuth getInstance() {
        if (instance == null) {
            synchronized (CtAuth.class) {
                if (instance == null) {
                    instance = new CtAuth();
                }
            }
        }
        return instance;
    }

    public Context getContext() {
        return mContext;
    }

    public void init(Context context, String str, String str2, TraceLogger traceLogger) {
        if (context == null) {
            throw new IllegalArgumentException("context must not be null!");
        }
        if (str == null) {
            throw new IllegalArgumentException("appId must not be null!");
        }
        if (str2 == null) {
            throw new IllegalArgumentException("appSecret must not be null!");
        }
        if (context instanceof Application) {
            mContext = context;
        } else {
            mContext = context.getApplicationContext();
        }
        DnsUtils.init(mContext);
        mAppId = str;
        mAppSecret = str2;
        mTraceLogger = traceLogger;
    }

    public void setDomainName(String str, String str2, String str3) {
        NetUtil.preLoginDomainName = str;
        NetUtil.getTimestampDomainName = str2;
        NetUtil.uploadLogDomainName = str3;
    }

    @Deprecated
    public void requestPreCode(CtSetting ctSetting, ResultListener resultListener) {
        requestPreLogin(ctSetting, resultListener);
    }

    public void requestPreLogin(CtSetting ctSetting, ResultListener resultListener) {
        requestPreLogin(ctSetting, CtSdkApi.AUTH_ONEKEY, resultListener);
    }

    public void requestPreLogin(CtSetting ctSetting, int i, ResultListener resultListener) {
        info(TAG, "called requestPreLogin()");
        if (resultListener == null) {
            return;
        }
        if (mContext == null || TextUtils.isEmpty(mAppId) || TextUtils.isEmpty(mAppSecret)) {
            postResultOnMainThread(null, ResultUtils.getInitError(), resultListener);
            return;
        }
        if (!NetUtil.isNetworkAvailable(mContext)) {
            postResultOnMainThread(null, ResultUtils.getNetworkDisable(), resultListener);
            return;
        }
        if (NetUtil.isMobileNet(mContext)) {
            new AuthManager(mContext, mAppId, mAppSecret).requestPreLogin4G(Xor.de(Constants.params3), ctSetting, i, resultListener);
        } else if (NetUtil.isMobileEnabled(mContext)) {
            new AuthManager(mContext, mAppId, mAppSecret).requestPreLoginBoth(Xor.de(Constants.params3), ctSetting, i, resultListener);
        } else {
            postResultOnMainThread(null, ResultUtils.getMobileNetDisable(), resultListener);
        }
    }

    public boolean isMobileDataEnabled() {
        Context context = mContext;
        if (context == null) {
            throw new IllegalArgumentException("Please call the init method");
        }
        return NetUtil.isMobileEnabled(context);
    }

    public String getOperatorType() {
        Context context = mContext;
        if (context == null) {
            throw new IllegalArgumentException("Please call the init method");
        }
        return NetUtil.getOperatorType(context, false);
    }

    public static void postResultOnMainThread(final String str, final JSONObject jSONObject, final ResultListener resultListener) {
        mHandler.post(new Runnable() { // from class: cn.com.chinatelecom.account.api.CtAuth.1
            @Override // java.lang.Runnable
            public void run() {
                if (resultListener != null) {
                    try {
                        String str2 = str;
                        if (str2 != null) {
                            jSONObject.put("reqId", str2);
                        }
                        resultListener.onResult(jSONObject.toString());
                    } catch (Throwable th) {
                        th.printStackTrace();
                    }
                    LogUtils.upload(str);
                }
            }
        });
    }

    public static void info(String str, String str2) {
        if (mTraceLogger != null) {
            mTraceLogger.info("CT_" + str, str2);
        }
    }

    public static void warn(String str, String str2, Throwable th) {
        if (mTraceLogger != null) {
            mTraceLogger.warn("CT_" + str, str2, th);
        }
    }
}
