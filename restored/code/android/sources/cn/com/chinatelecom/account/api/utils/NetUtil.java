package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.CtAuth;
import com.baidu.mobads.sdk.internal.bn;
import com.sigmob.sdk.base.mta.PointType;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes.dex */
public class NetUtil {
    public static final String DM_CARD = "2";
    public static final String DM_ID6 = "1";
    private static final int NETWORK_CLASS_2_G = 1;
    private static final int NETWORK_CLASS_3_G = 2;
    private static final int NETWORK_CLASS_4_G = 3;
    public static final int NETWORK_CLASS_5_G = 4;
    private static final int NETWORK_CLASS_UNAVAILABLE = -1;
    private static final int NETWORK_CLASS_UNKNOWN = 0;
    private static final int NETWORK_CLASS_WIFI = -101;
    public static final int NETWORK_TYPE_1xRTT = 7;
    public static final int NETWORK_TYPE_CDMA = 4;
    public static final int NETWORK_TYPE_EDGE = 2;
    public static final int NETWORK_TYPE_EHRPD = 14;
    public static final int NETWORK_TYPE_EVDO_0 = 5;
    public static final int NETWORK_TYPE_EVDO_A = 6;
    public static final int NETWORK_TYPE_EVDO_B = 12;
    public static final int NETWORK_TYPE_GPRS = 1;
    public static final int NETWORK_TYPE_GSM = 16;
    public static final int NETWORK_TYPE_HSDPA = 8;
    public static final int NETWORK_TYPE_HSPA = 10;
    public static final int NETWORK_TYPE_HSPAP = 15;
    public static final int NETWORK_TYPE_HSUPA = 9;
    public static final int NETWORK_TYPE_IDEN = 11;
    public static final int NETWORK_TYPE_IWLAN = 18;
    public static final int NETWORK_TYPE_LTE = 13;
    public static final int NETWORK_TYPE_LTE_CA = 19;
    public static final int NETWORK_TYPE_NR = 20;
    public static final int NETWORK_TYPE_TD_SCDMA = 17;
    public static final int NETWORK_TYPE_UMTS = 3;
    private static final int NETWORK_TYPE_UNAVAILABLE = -1;
    public static final int NETWORK_TYPE_UNKNOWN = 0;
    private static final int NETWORK_TYPE_WIFI = -101;
    public static final String ONLINE_TYPE_MOBILE = "0";
    public static final String ONLINE_TYPE_MOBILE_AND_WIFI = "1";
    public static final String ONLINE_TYPE_WIFI_ONLY = "2";
    private static final String TAG = "NetUtil";
    private static final String[] CM = {"46000", "46002", "46004", "46007", "46008"};
    private static final String[] CT = {"46003", "46005", "46011"};
    private static final String[] CU = {"46001", "46006", "46009"};
    public static String preLoginDomainName = null;
    public static String getTimestampDomainName = null;
    public static String uploadLogDomainName = null;
    public static String operatorType = "0";

    private static int getNetworkClassByType(int i) {
        int i2 = -101;
        if (i != -101) {
            i2 = -1;
            if (i != -1) {
                switch (i) {
                    case 1:
                    case 2:
                    case 4:
                    case 7:
                    case 11:
                    case 16:
                        return 1;
                    case 3:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                    case 12:
                    case 14:
                    case 15:
                    case 17:
                        return 2;
                    case 13:
                    case 18:
                    case 19:
                        return 3;
                    case 20:
                        return 4;
                    default:
                        return i;
                }
            }
        }
        return i2;
    }

    public static NetworkInfo getActiveNetInfo(Context context) {
        if (context == null) {
            return null;
        }
        return ((ConnectivityManager) context.getSystemService("connectivity")).getActiveNetworkInfo();
    }

    public static boolean isNetworkAvailable(Context context) {
        NetworkInfo activeNetInfo = getActiveNetInfo(context);
        return activeNetInfo != null && activeNetInfo.isAvailable();
    }

    public static boolean isWifiEnabled(Context context) {
        NetworkInfo activeNetInfo = getActiveNetInfo(context);
        return activeNetInfo != null && activeNetInfo.getType() == 1;
    }

    public static boolean isMobileNet(Context context) {
        NetworkInfo activeNetInfo = getActiveNetInfo(context);
        return activeNetInfo != null && activeNetInfo.getType() == 0;
    }

    public static boolean isMobileEnabled(Context context) {
        if (context == null) {
            return true;
        }
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getApplicationContext().getSystemService("connectivity");
            Method declaredMethod = ConnectivityManager.class.getDeclaredMethod("getMobileDataEnabled", new Class[0]);
            declaredMethod.setAccessible(true);
            return ((Boolean) declaredMethod.invoke(connectivityManager, new Object[0])).booleanValue();
        } catch (Throwable th) {
            CtAuth.warn(TAG, "isMobileEnable error ", th);
            return true;
        }
    }

    private static Object getConnectivityManager(Context context) {
        ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService("connectivity");
        try {
            Field declaredField = Class.forName(connectivityManager.getClass().getName()).getDeclaredField("mService");
            declaredField.setAccessible(true);
            return declaredField.get(connectivityManager);
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            return null;
        } catch (IllegalAccessException e2) {
            e2.printStackTrace();
            return null;
        } catch (NoSuchFieldException e3) {
            e3.printStackTrace();
            return null;
        }
    }

    public static String getCurrentNetworkType(Context context) {
        int networkClass = getNetworkClass(context);
        if (networkClass == -101) {
            return "wifi";
        }
        if (networkClass == -1) {
            return "unnet";
        }
        if (networkClass == 0) {
            return "-1";
        }
        if (networkClass == 1) {
            return "2g";
        }
        if (networkClass == 2) {
            return "3g";
        }
        if (networkClass != 3) {
            return networkClass != 4 ? Integer.toString(networkClass) : "5g";
        }
        return "4g";
    }

    private static int getNetworkClass(Context context) {
        int subtype = 0;
        try {
            NetworkInfo activeNetInfo = getActiveNetInfo(context);
            if (activeNetInfo != null && activeNetInfo.isAvailable() && activeNetInfo.isConnected()) {
                int type = activeNetInfo.getType();
                if (type == 1) {
                    subtype = -101;
                } else if (type == 0) {
                    subtype = activeNetInfo.getSubtype();
                }
            } else {
                subtype = -1;
            }
        } catch (NullPointerException e) {
            e.printStackTrace();
        } catch (Exception e2) {
            e2.printStackTrace();
        }
        return getNetworkClassByType(subtype);
    }

    public static String getNetState(Context context) {
        int networkClass = getNetworkClass(context);
        if (networkClass == -101) {
            return "WIFI";
        }
        if (networkClass == -1 || networkClass == 0) {
            return "null";
        }
        if (networkClass == 1) {
            return "2G";
        }
        if (networkClass == 2) {
            return "3G";
        }
        if (networkClass != 3) {
            return networkClass != 4 ? Integer.toString(networkClass) : "5G";
        }
        return "4G";
    }

    public static String getNetStateForLog(Context context) {
        String netState = getNetState(context);
        return (netState != null && netState.equals("WIFI") && isMobileEnabled(context)) ? "BOTH" : netState;
    }

    public static String getOnlineType(Context context) {
        String netStateForLog = getNetStateForLog(context);
        if (!TextUtils.isEmpty(netStateForLog) && !netStateForLog.equals("null")) {
            if (netStateForLog.equals("2G")) {
                return PointType.SIGMOB_APP;
            }
            if (netStateForLog.equals("3G")) {
                return "11";
            }
            if (netStateForLog.equals("4G")) {
                return "12";
            }
            if (netStateForLog.equals("5G")) {
                return "16";
            }
            if (netStateForLog.equals("WIFI")) {
                return PointType.SIGMOB_REPORT_TRACKING;
            }
            if (netStateForLog.equals("BOTH")) {
                return "14";
            }
        }
        return "15";
    }

    public static String getPreLoginDomainName() {
        return preLoginDomainName;
    }

    public static String getGetTimestampUrl() {
        return getTimestampDomainName != null ? Constants.GET_TIMESTAMP_URL.replace(cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsOpenDomain), getTimestampDomainName) : Constants.GET_TIMESTAMP_URL;
    }

    public static String getUploadLogUrl() {
        String str = uploadLogDomainName;
        return str != null ? Constants.GET_LOG_COLLECT_URL.replace(Constants.paramsUxDomain, str) : Constants.GET_LOG_COLLECT_URL;
    }

    public static String getSimOperator(Context context) {
        try {
            String simOperator = ((TelephonyManager) context.getSystemService("phone")).getSimOperator();
            return !TextUtils.isEmpty(simOperator) ? simOperator : "00000";
        } catch (Throwable th) {
            th.printStackTrace();
            return "00000";
        }
    }

    public static String getSimOperatorForLog(Context context) {
        return getOperatorType(context, true);
    }

    public static String getOperatorType(Context context, boolean z) {
        String simOperator = getSimOperator(context);
        if (simOperator != null) {
            for (String str : CT) {
                if (simOperator.equals(str)) {
                    return z ? "1" : "CT";
                }
            }
            for (String str2 : CM) {
                if (simOperator.equals(str2)) {
                    return z ? "2" : "CM";
                }
            }
            for (String str3 : CU) {
                if (simOperator.equals(str3)) {
                    return z ? "3" : "CU";
                }
            }
        }
        return z ? "0" : "UN";
    }

    public static String getPreLoginUrl(Context context, String str) {
        String requestDomainType = getRequestDomainType(context);
        String strDe = cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsId6Domain);
        String strDe2 = cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsCardDomain);
        if (TextUtils.isEmpty(requestDomainType)) {
            return str.replace(strDe, strDe2);
        }
        if (requestDomainType.equals("1") && str.contains(strDe2)) {
            return str.replace(strDe2, strDe);
        }
        return (requestDomainType.equals("2") && str.contains(strDe)) ? str.replace(strDe, strDe2) : str;
    }

    public static String getPreLoginDomain(Context context) {
        String requestDomainType = getRequestDomainType(context);
        if (TextUtils.isEmpty(requestDomainType) || requestDomainType.equals("2")) {
            return cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsCardDomain);
        }
        return cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsId6Domain);
    }

    public static void saveRequestDomainType(Context context, String str) {
        try {
            DefaultShared.putString(context, Constants.KEY_GET_HEADER_DM, str);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static String getRequestDomainType(Context context) {
        if (System.currentTimeMillis() - getRequestDomainTypeTime(context) > bn.e) {
            return null;
        }
        try {
            return DefaultShared.getString(context, Constants.KEY_GET_HEADER_DM, null);
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static void saveRequestDomainTypeTime(Context context, long j) {
        try {
            DefaultShared.putLong(context, Constants.KEY_GET_HEADER_DM_TIME, j);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static long getRequestDomainTypeTime(Context context) {
        Long lValueOf;
        try {
            lValueOf = Long.valueOf(DefaultShared.getLong(context, Constants.KEY_GET_HEADER_DM_TIME, 0L));
        } catch (Exception e) {
            e.printStackTrace();
            lValueOf = null;
        }
        return lValueOf.longValue();
    }

    public static String getPreLoginUrlNew(Context context) {
        String requestDomainType = getRequestDomainType(context);
        String preLoginUrl = ParamFactory.getPreLoginUrl();
        return (TextUtils.isEmpty(requestDomainType) || requestDomainType.equals("1") || !requestDomainType.equals("2")) ? preLoginUrl : ParamFactory.getPreLoginUrl().replace(cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsId6Domain), cn.com.chinatelecom.account.api.encrypt.Xor.de(Constants.paramsCardDomain));
    }
}
