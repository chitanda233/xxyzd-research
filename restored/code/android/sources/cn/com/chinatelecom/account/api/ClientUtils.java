package cn.com.chinatelecom.account.api;

import android.content.Context;
import android.os.Build;
import android.os.Process;
import android.util.Log;
import cn.com.chinatelecom.account.api.encrypt.RSAUtils;
import cn.com.chinatelecom.account.api.encrypt.SHA_256;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.DeviceInfoUtil;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import java.io.FileInputStream;
import java.security.interfaces.RSAPublicKey;

/* JADX INFO: loaded from: classes.dex */
public final class ClientUtils {
    private static final String TAG = "ClientUtils";
    public static final int TYPE_SDK_API = 0;
    public static final int TYPE_SDK_BIO = 2;
    public static final int TYPE_SDK_HY = 1;
    private static int sdkType;

    public static String getApiVersion() {
        return Constants.CT_VERSION;
    }

    public static boolean isJY() {
        return true;
    }

    public static String getModel() {
        return Build.MODEL;
    }

    public static String getMobileBrand() {
        return Build.BRAND;
    }

    public static String getSdkVersion() {
        int i = sdkType;
        if (i == 1) {
            return Constants.SDK_VERSION_HY;
        }
        return i == 2 ? Constants.SDK_VERSION_BIOM : Constants.SDK_VERSION_API;
    }

    public static void setSdkType(int i) {
        sdkType = i;
    }

    public static int getSdkType() {
        return sdkType;
    }

    public static long getTp() {
        return System.currentTimeMillis();
    }

    public static String getCurrentNetworkType(Context context) {
        return NetUtil.getNetStateForLog(context);
    }

    public static String getOnlineType(Context context) {
        return NetUtil.getOnlineType(context);
    }

    public static String getOperatorType(Context context) {
        return NetUtil.getSimOperator(context);
    }

    public static String getOs() {
        return getMobileBrand() + "-" + getModel() + "-A:" + Build.VERSION.RELEASE;
    }

    public static String getPID() {
        String strSubstring = "";
        try {
            String str = Thread.currentThread().getId() + "" + Process.myPid();
            if (str.length() <= 6) {
                return "ctacco";
            }
            strSubstring = str.substring(0, 6);
            return strSubstring;
        } catch (Exception e) {
            e.printStackTrace();
            return strSubstring;
        }
    }

    public static String enrdata(String str, String str2) {
        try {
            return RSAUtils.encryptWithHex(str, (RSAPublicKey) RSAUtils.getPublicKey(str2));
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static String hashEncryption(String str) {
        return SHA_256.encryptSHA256(str);
    }

    public static String hashEncryption(FileInputStream fileInputStream) {
        return SHA_256.encryptSHA256(fileInputStream);
    }

    public static String hmacHashEncryption(String str, String str2) {
        return SHA_256.encryptHMACSHA256(str, str2);
    }

    public static boolean getMacData() {
        try {
            return DeviceInfoUtil.isRoot();
        } catch (Throwable th) {
            CtAuth.warn(TAG, "getMacData error ：" + th.getMessage(), th);
            return false;
        }
    }

    public static boolean getTimePass(Context context) {
        try {
            return DeviceInfoUtil.isProxy(context) || DeviceInfoUtil.isVpn();
        } catch (Throwable th) {
            CtAuth.warn(TAG, "getTimePass error ：" + th.getMessage(), th);
            return false;
        }
    }

    public static boolean getNetSafe(Context context) {
        try {
            return DeviceInfoUtil.isHook(context);
        } catch (Throwable th) {
            CtAuth.warn(TAG, "getNetSafe error ：" + th.getMessage(), th);
            return false;
        }
    }

    public static boolean getHealthy(Context context) {
        try {
            return DeviceInfoUtil.isEmu(context);
        } catch (Throwable th) {
            CtAuth.warn(TAG, "getHealthy error ：" + th.getMessage(), th);
            return false;
        }
    }

    public static boolean objChange(Object obj, String str) {
        try {
            return DeviceInfoUtil.apRef(obj, str);
        } catch (Throwable th) {
            CtAuth.warn(TAG, "objChange error ：" + th.getMessage(), th);
            return false;
        }
    }

    public static String strBuf() {
        try {
            return DeviceInfoUtil.getIpList().toString();
        } catch (Throwable th) {
            CtAuth.warn(TAG, "strBuf error ：" + th.getMessage(), th);
            return "";
        }
    }

    public static String getAppName(Context context) {
        try {
            int i = context.getPackageManager().getPackageInfo(context.getPackageName(), 0).applicationInfo.labelRes;
            Log.d("getAppName", "------------------->");
            return context.getResources().getString(i);
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }
}
