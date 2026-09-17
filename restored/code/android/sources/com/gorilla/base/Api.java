package com.gorilla.base;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.content.Intent;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.plugin.ActivityResultListener;
import com.gorilla.base.plugin.GorillaPlugin;
import com.gorilla.base.plugin.ILoginService;
import com.gorilla.base.plugin.INumberAuthService;
import com.gorilla.base.plugin.IPurchaseService;
import com.gorilla.base.plugin.IShareService;
import com.gorilla.base.service.AlternateIconService;
import com.gorilla.base.service.MetaDataService;
import com.gorilla.base.service.PaymentSelectorService;
import com.gorilla.base.service.PrivacyPolicyService;
import com.gorilla.base.service.SignatureGenerator;
import com.gorilla.base.service.SystemShareService;
import com.gorilla.base.service.SystemSmsService;
import java.util.HashMap;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class Api {
    private static final String TAG = "[Api]";
    private static final AtomicBoolean isAppCreated = new AtomicBoolean(false);
    private static final HashMap<String, GorillaPlugin> plugins = new HashMap<>();
    public static ILogger logger = LogFactory.getLogger();

    public static void enableLog(boolean z) {
        LogFactory.enableLog(z);
    }

    public static void registerPlugin(String str) {
        GorillaPlugin gorillaPlugin;
        try {
            gorillaPlugin = (GorillaPlugin) Class.forName(str).getDeclaredConstructor(new Class[0]).newInstance(new Object[0]);
        } catch (ClassNotFoundException unused) {
            logger.error(TAG, "Plugin not found for name: " + str);
            gorillaPlugin = null;
        } catch (IllegalAccessException unused2) {
            logger.error(TAG, "Plugin cannot be accessed for name: " + str);
            gorillaPlugin = null;
        } catch (InstantiationException unused3) {
            logger.error(TAG, "Plugin cannot be instantiated for name: " + str);
            gorillaPlugin = null;
        } catch (Exception unused4) {
            logger.error(TAG, "Plugin cannot be initialized for name: " + str);
            gorillaPlugin = null;
        }
        if (gorillaPlugin == null) {
            logger.error(TAG, "Plugin not found for name: " + str);
        } else {
            plugins.put(str, gorillaPlugin);
            logger.log(TAG, String.format("Registered plugin: %s, version: %s", str, gorillaPlugin.getVersion()));
        }
    }

    public static void onApplicationCreate(Context context) {
        if (!isAppCreated.compareAndSet(false, true)) {
            logger.log(TAG, "Already initialized, skip.");
            return;
        }
        if (context == null) {
            logger.error(TAG, "Context cannot be null.");
            return;
        }
        Context applicationContext = context.getApplicationContext();
        if (applicationContext instanceof Application) {
            logger.log(TAG, "Initializing Gorilla SDK.");
            Application application = (Application) applicationContext;
            MetaDataService.init(application);
            application.registerActivityLifecycleCallbacks(new ActivityLifecycleObserver());
            return;
        }
        logger.error(TAG, "Context is not an instance of Application.");
    }

    public static void init(Activity activity) {
        if (activity == null) {
            logger.error(TAG, "Activity cannot be null.");
            return;
        }
        logger.log(TAG, "Init Gorilla SDK with: " + activity.getClass().getName());
        GorillaContext.init(activity);
        logger.log(TAG, "Signature MD5: " + SignatureGenerator.getSignatureMD5(activity));
        logger.log(TAG, "Signature SHA1: " + SignatureGenerator.getSignatureSHA1(activity));
        logger.log(TAG, "Signature SHA256: " + SignatureGenerator.getSignatureSHA256(activity));
        try {
            for (GorillaPlugin gorillaPlugin : plugins.values()) {
                if (gorillaPlugin != null && !gorillaPlugin.isInit) {
                    gorillaPlugin.init(GorillaContext.getInstance().getActivity(), null);
                }
            }
        } catch (Exception e) {
            logger.error(TAG, "Plugin init error: " + e.getMessage());
        }
    }

    public static boolean isInstalled(String str) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof ILoginService) {
            return ((ILoginService) obj).isInstalled();
        }
        logger.error(TAG, "Plugin not found for name: " + str);
        return false;
    }

    public static void login(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof ILoginService) {
            ((ILoginService) obj).login(jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
            return;
        }
        logger.error(TAG, "Plugin not found for name: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "Plugin not found for name: " + str);
        }
    }

    public static void logout(String str, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof ILoginService) {
            ((ILoginService) obj).logout(iSuccessCallback, iFailureCallback);
            return;
        }
        logger.error(TAG, "Plugin not found for name: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "Plugin not found for name: " + str);
        }
    }

    public static void onActivityResult(int i, int i2, Intent intent) {
        for (Object obj : plugins.values()) {
            if (obj instanceof ActivityResultListener) {
                ((ActivityResultListener) obj).onActivityResult(i, i2, intent);
            }
        }
    }

    public static void purchase(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof IPurchaseService) {
            ((IPurchaseService) obj).purchase(jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
            return;
        }
        logger.error(TAG, "Plugin not found for name: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "Plugin not found for name: " + str);
        }
    }

    public static void share(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof IShareService) {
            ((IShareService) obj).share(jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
            return;
        }
        logger.error(TAG, "Plugin not found for name: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "Plugin not found for name: " + str);
        }
    }

    public static void systemShare(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        SystemShareService.share(jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    public static void showPayList(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        Activity activity = GorillaContext.getInstance() != null ? GorillaContext.getInstance().getActivity() : null;
        if (activity == null) {
            logger.error(TAG, "Activity unavailable for showPayList");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Activity unavailable for showPayList.");
                return;
            }
            return;
        }
        PaymentSelectorService.show(activity, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    public static void sendSms(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        SystemSmsService.send(GorillaContext.getInstance() != null ? GorillaContext.getInstance().getActivity() : null, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    public static void setAlternateIcon(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        AlternateIconService.setAlternateIcon(GorillaContext.getInstance() != null ? GorillaContext.getInstance().getActivity() : null, jSONObject, iSuccessCallback, iFailureCallback);
    }

    public static void showPrivacyPolicy(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        PrivacyPolicyService.show(GorillaContext.getInstance() != null ? GorillaContext.getInstance().getActivity() : null, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    public static void numberAuthInit(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof INumberAuthService) {
            ((INumberAuthService) obj).initSDK(jSONObject, iSuccessCallback, iFailureCallback);
            return;
        }
        logger.error(TAG, "NumberAuth plugin not found: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "NumberAuth plugin not found: " + str);
        }
    }

    public static void numberAuthPrepare(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof INumberAuthService) {
            ((INumberAuthService) obj).prepare(jSONObject, iSuccessCallback, iFailureCallback);
            return;
        }
        logger.error(TAG, "NumberAuth plugin not found: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "NumberAuth plugin not found: " + str);
        }
    }

    public static void numberAuthLogin(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof INumberAuthService) {
            ((INumberAuthService) obj).auth(jSONObject, iSuccessCallback, iFailureCallback);
            return;
        }
        logger.error(TAG, "NumberAuth plugin not found: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "NumberAuth plugin not found: " + str);
        }
    }

    public static void numberAuthDismiss(String str, JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        Object obj = (GorillaPlugin) plugins.get(str);
        if (obj instanceof INumberAuthService) {
            ((INumberAuthService) obj).dismiss(iSuccessCallback, iFailureCallback);
            return;
        }
        logger.error(TAG, "NumberAuth plugin not found: " + str);
        if (iFailureCallback != null) {
            iFailureCallback.onFailure(-1, "NumberAuth plugin not found: " + str);
        }
    }
}
