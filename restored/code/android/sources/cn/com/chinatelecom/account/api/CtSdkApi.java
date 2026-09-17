package cn.com.chinatelecom.account.api;

import android.content.Context;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.encrypt.Xor;
import cn.com.chinatelecom.account.api.utils.ApiUtils;
import cn.com.chinatelecom.account.api.utils.Constants;

/* JADX INFO: loaded from: classes.dex */
public class CtSdkApi {
    public static int AUTH_FACE = 2;
    public static int AUTH_FINGERPRINT = 1;
    public static int AUTH_NONE = 0;
    public static int AUTH_ONEKEY = 3;
    private static boolean isSupportedOnekey = false;

    public static String getSdkVersion() {
        return Constants.SDK_VERSION_HY;
    }

    public static void initSdkType() {
        ClientUtils.setSdkType(1);
    }

    public static void initBioSdk() {
        ClientUtils.setSdkType(2);
    }

    public static void setSupportedOnekey(String str) {
        String strDe = Xor.de(Constants.BIOM_SUPPORTED_ONEKEY_FLAG);
        if (str == null || !str.equals(strDe)) {
            return;
        }
        isSupportedOnekey = true;
    }

    public static boolean isSupportedOnekey() {
        return isSupportedOnekey;
    }

    public static String saveGwAuth(String str) {
        return Helper.sgwret(str);
    }

    public static String getAuthCode(Context context, String str) {
        return Helper.gscret(context, str);
    }

    public static String getAppId() {
        return CtAuth.mAppId;
    }

    public static String getAppSecret() {
        return CtAuth.mAppSecret;
    }

    public static boolean isResetPage(Context context) {
        String pageReset = ApiUtils.getPageReset(context);
        return !TextUtils.isEmpty(pageReset) && pageReset.equals("1");
    }
}
