package cn.thinkingdata.core.preset;

import android.content.Context;
import android.content.res.Resources;
import android.graphics.Point;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkCapabilities;
import android.net.NetworkInfo;
import android.os.Build;
import android.os.LocaleList;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.Display;
import android.view.WindowManager;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.thinkingdata.core.receiver.TDNetWorkObservable;
import cn.thinkingdata.core.receiver.TDNetWorkObserver;
import cn.thinkingdata.core.utils.EmulatorDetector;
import cn.thinkingdata.core.utils.TAReflectUtils;
import cn.thinkingdata.core.utils.TDLog;
import com.kuaishou.weapon.p0.g;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class TDPresetModel implements TDNetWorkObserver {
    private static final String TAG = "ThinkingAnalytics.PresetProperties";
    private static volatile TDPresetModel instance;
    private String currentNetworkType;
    private String mAppVersionName;
    private final Context mContext;
    private final boolean mHasPermission;
    private final PresetStoragePlugin presetStoragePlugin;
    private final Map<String, Object> mPresetProperties = new HashMap();
    private boolean isNetWorkChanged = false;
    private volatile String mDeviceId = null;
    List<String> disableList = new ArrayList();

    private TDPresetModel(Context context) {
        Context applicationContext = context.getApplicationContext();
        this.mContext = applicationContext;
        this.mHasPermission = checkHasPermission(applicationContext, g.b);
        this.presetStoragePlugin = new PresetStoragePlugin(applicationContext);
        initPresetProperties(context);
        TDNetWorkObservable.getInstance(applicationContext).addNetWorkObserver(this);
    }

    private boolean checkHasPermission(Context context, String str) {
        Class<?> cls;
        try {
            cls = Class.forName("androidx.core.content.ContextCompat");
        } catch (Exception unused) {
            cls = null;
        }
        if (cls == null) {
            try {
                cls = Class.forName("androidx.core.content.ContextCompat");
            } catch (Exception unused2) {
            }
        }
        if (cls == null) {
            return true;
        }
        try {
            if (((Integer) cls.getMethod("checkSelfPermission", Context.class, String.class).invoke(null, context, str)).intValue() == 0) {
                return true;
            }
            TDLog.w(TAG, "You can fix this by adding the following to your AndroidManifest.xml file:\n<uses-permission android:name=\"" + str + "\" />");
            return false;
        } catch (Exception e) {
            TDLog.w(TAG, e.toString());
            return true;
        }
    }

    private String getCarrier(Context context) {
        HashMap<String, String> map = new HashMap<String, String>() { // from class: cn.thinkingdata.core.preset.TDPresetModel.1
            {
                put("46000", "中国移动");
                put("46002", "中国移动");
                put("46007", "中国移动");
                put("46008", "中国移动");
                put("46001", "中国联通");
                put("46006", "中国联通");
                put("46009", "中国联通");
                put("46003", "中国电信");
                put("46005", "中国电信");
                put("46011", "中国电信");
                put("46004", "中国卫通");
                put("46020", "中国铁通");
            }
        };
        try {
            TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
            String simOperator = telephonyManager.getSimOperator();
            if (!TextUtils.isEmpty(simOperator) && map.containsKey(simOperator)) {
                return map.get(simOperator);
            }
            String simOperatorName = telephonyManager.getSimOperatorName();
            return !TextUtils.isEmpty(simOperatorName) ? simOperatorName : "";
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    private String getDeviceIDInternal() {
        String strValueOf = (String) this.presetStoragePlugin.get(100);
        if (TextUtils.isEmpty(strValueOf)) {
            Object objInvokeMethod = TAReflectUtils.invokeMethod(TAReflectUtils.createObject("cn.thinkingdata.core.utils.TASensitiveInfo"), "getAndroidID", new Object[]{this.mContext}, Context.class);
            strValueOf = objInvokeMethod == null ? "" : String.valueOf(objInvokeMethod);
            if (TextUtils.isEmpty(strValueOf)) {
                strValueOf = TDPresetUtils.getRandomHEXValue(16);
            }
            try {
                if (Integer.parseInt(strValueOf) == 0) {
                    strValueOf = TDPresetUtils.getRandomHEXValue(16);
                }
            } catch (Exception unused) {
            }
            this.presetStoragePlugin.save(100, strValueOf);
        }
        return strValueOf;
    }

    private int[] getDeviceSize(Context context) {
        int[] iArr = new int[2];
        try {
            Display defaultDisplay = ((WindowManager) context.getSystemService("window")).getDefaultDisplay();
            int rotation = defaultDisplay.getRotation();
            Point point = new Point();
            defaultDisplay.getRealSize(point);
            int i = point.x;
            int i2 = point.y;
            iArr[0] = getNaturalWidth(rotation, i, i2);
            iArr[1] = getNaturalHeight(rotation, i, i2);
        } catch (Exception unused) {
            if (context.getResources() != null) {
                DisplayMetrics displayMetrics = context.getResources().getDisplayMetrics();
                iArr[0] = displayMetrics.widthPixels;
                iArr[1] = displayMetrics.heightPixels;
            }
        }
        return iArr;
    }

    public static TDPresetModel getInstance(Context context) {
        if (instance == null) {
            synchronized (TDPresetModel.class) {
                if (instance == null) {
                    instance = new TDPresetModel(context);
                }
            }
        }
        return instance;
    }

    private int getNaturalHeight(int i, int i2, int i3) {
        return (i == 0 || i == 2) ? i3 : i2;
    }

    private int getNaturalWidth(int i, int i2, int i3) {
        return (i == 0 || i == 2) ? i2 : i3;
    }

    private String getNetworkType() {
        NetworkInfo networkInfo;
        try {
            if (!this.mHasPermission) {
                return "NULL";
            }
            ConnectivityManager connectivityManager = (ConnectivityManager) this.mContext.getSystemService("connectivity");
            return (connectivityManager == null || (networkInfo = connectivityManager.getNetworkInfo(1)) == null || !networkInfo.isConnectedOrConnecting()) ? mobileNetworkType(this.mContext, (TelephonyManager) this.mContext.getSystemService("phone"), connectivityManager) : "WIFI";
        } catch (Exception unused) {
            return "NULL";
        }
    }

    private String getSystemLanguage() {
        return LocaleList.getDefault().get(0).getLanguage();
    }

    private void initPresetProperties(Context context) {
        String str;
        Map<String, Object> map;
        String str2;
        try {
            Resources resources = context.getResources();
            str = TDPresetUtils.KEY_DEVICE_TYPE;
            try {
                this.disableList.addAll(Arrays.asList(resources.getStringArray(resources.getIdentifier("TDDisPresetProperties", "array", context.getPackageName()))));
            } catch (Exception unused) {
            }
        } catch (Exception unused2) {
            str = TDPresetUtils.KEY_DEVICE_TYPE;
        }
        try {
            String harmonyOSVersion = TDPresetUtils.getHarmonyOSVersion();
            if (!this.disableList.contains(TDPresetUtils.KEY_OS)) {
                if (TextUtils.isEmpty(harmonyOSVersion)) {
                    map = this.mPresetProperties;
                    str2 = Constants.LOG_OS;
                } else {
                    map = this.mPresetProperties;
                    str2 = "HarmonyOS";
                }
                map.put(TDPresetUtils.KEY_OS, str2);
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_OS_VERSION)) {
                if (TextUtils.isEmpty(harmonyOSVersion)) {
                    this.mPresetProperties.put(TDPresetUtils.KEY_OS_VERSION, Build.VERSION.RELEASE);
                } else {
                    this.mPresetProperties.put(TDPresetUtils.KEY_OS_VERSION, harmonyOSVersion);
                }
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_BUNDLE_ID)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_BUNDLE_ID, TDPresetUtils.getCurrentProcessName(context));
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_MANUFACTURER)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_MANUFACTURER, Build.MANUFACTURER);
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_DEVICE_MODEL)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_DEVICE_MODEL, Build.MODEL);
            }
            int[] deviceSize = getDeviceSize(context);
            if (!this.disableList.contains(TDPresetUtils.KEY_SCREEN_WIDTH)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_SCREEN_WIDTH, Integer.valueOf(deviceSize[0]));
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_SCREEN_HEIGHT)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_SCREEN_HEIGHT, Integer.valueOf(deviceSize[1]));
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_CARRIER)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_CARRIER, getCarrier(context));
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_SYSTEM_LANGUAGE)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_SYSTEM_LANGUAGE, getSystemLanguage());
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_APP_VERSION)) {
                String str3 = context.getPackageManager().getPackageInfo(context.getPackageName(), 0).versionName;
                this.mAppVersionName = str3;
                if (!TextUtils.isEmpty(str3)) {
                    this.mPresetProperties.put(TDPresetUtils.KEY_APP_VERSION, this.mAppVersionName);
                }
            }
            if (!this.disableList.contains(TDPresetUtils.KEY_SIMULATOR)) {
                this.mPresetProperties.put(TDPresetUtils.KEY_SIMULATOR, Boolean.valueOf(EmulatorDetector.isEmulator()));
            }
            String str4 = str;
            if (this.disableList.contains(str4)) {
                return;
            }
            this.mPresetProperties.put(str4, TDPresetUtils.getDeviceType(context));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private String mobileNetworkType(Context context, TelephonyManager telephonyManager, ConnectivityManager connectivityManager) {
        int networkType;
        NetworkInfo activeNetworkInfo;
        if (telephonyManager != null) {
            try {
                networkType = (Build.VERSION.SDK_INT < 30 || !checkHasPermission(context, g.c)) ? telephonyManager.getNetworkType() : telephonyManager.getDataNetworkType();
            } catch (Exception unused) {
                networkType = 0;
            }
        } else {
            networkType = 0;
        }
        if (networkType == 0 && connectivityManager != null && (activeNetworkInfo = connectivityManager.getActiveNetworkInfo()) != null) {
            networkType = activeNetworkInfo.getSubtype();
        }
        switch (networkType) {
            case 1:
            case 2:
            case 4:
            case 7:
            case 11:
            case 16:
                return "2G";
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
                return "3G";
            case 13:
            case 18:
            case 19:
                return "4G";
            case 20:
                return "5G";
            default:
                return "NULL";
        }
    }

    public String getAppVersionName() {
        return this.mAppVersionName;
    }

    public String getCurrentNetworkType() {
        if ((this.isNetWorkChanged && "NULL".equals(this.currentNetworkType)) || this.currentNetworkType == null) {
            String networkType = getNetworkType();
            this.currentNetworkType = networkType;
            if (!"NULL".equals(networkType)) {
                this.isNetWorkChanged = true;
            }
        }
        return this.currentNetworkType;
    }

    public String getDeviceId() {
        if (this.mDeviceId == null && !this.disableList.contains(TDPresetUtils.KEY_DEVICE_ID)) {
            synchronized (this) {
                if (this.mDeviceId == null) {
                    this.mDeviceId = getDeviceIDInternal();
                }
            }
        }
        return this.mDeviceId;
    }

    public Map<String, Object> getPresetProperties() {
        return this.mPresetProperties;
    }

    @Override // cn.thinkingdata.core.receiver.TDNetWorkObserver
    public void onAvailable(Network network) {
        this.currentNetworkType = getNetworkType();
        this.isNetWorkChanged = true;
    }

    @Override // cn.thinkingdata.core.receiver.TDNetWorkObserver
    public void onCapabilitiesChanged(Network network, NetworkCapabilities networkCapabilities) {
    }

    @Override // cn.thinkingdata.core.receiver.TDNetWorkObserver
    public void onChange() {
        this.currentNetworkType = getNetworkType();
        this.isNetWorkChanged = true;
    }

    @Override // cn.thinkingdata.core.receiver.TDNetWorkObserver
    public void onLost(Network network) {
        this.currentNetworkType = "NULL";
    }
}
