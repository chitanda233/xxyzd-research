package cn.thinkingdata.analytics.e;

import android.app.ActivityManager;
import android.content.Context;
import android.content.pm.PackageInfo;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Build;
import android.os.StatFs;
import android.os.storage.StorageManager;
import android.text.TextUtils;
import cn.thinkingdata.analytics.TDPresetProperties;
import cn.thinkingdata.analytics.h.n;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.preset.TDPresetModel;
import cn.thinkingdata.core.utils.TDLog;
import com.byazt.hv.TTDownloadField;
import java.io.File;
import java.lang.reflect.Array;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;
import java.util.TimeZone;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class e {
    private static String g = "Android";
    private static String h = "3.1.1";
    private static e i;
    private static final Object j = new Object();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private long f97a;
    private final TimeZone b;
    private final Map<String, Object> c;
    private final Context d;
    private final boolean e;
    private String f;

    private e(Context context, TimeZone timeZone) {
        Context applicationContext = context.getApplicationContext();
        this.d = applicationContext;
        this.b = timeZone;
        this.e = a(applicationContext, com.kuaishou.weapon.p0.g.b);
        try {
            PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
            this.f97a = packageInfo.firstInstallTime;
            long j2 = packageInfo.lastUpdateTime;
            TDLog.d("ThinkingAnalytics.SystemInformation", "First Install Time: " + packageInfo.firstInstallTime);
            TDLog.d("ThinkingAnalytics.SystemInformation", "Last Update Time: " + packageInfo.lastUpdateTime);
        } catch (Exception unused) {
            TDLog.d("ThinkingAnalytics.SystemInformation", "Exception occurred in getting app version");
        }
        this.c = c(context);
    }

    public static e a(Context context, TimeZone timeZone) {
        e eVar;
        synchronized (j) {
            if (i == null) {
                i = new e(context, timeZone);
            }
            eVar = i;
        }
        return eVar;
    }

    public static void a(String str, String str2) {
        if (!TextUtils.isEmpty(str)) {
            g = str;
            TDLog.d("ThinkingAnalytics.SystemInformation", "#lib has been changed to: " + str);
        }
        if (TextUtils.isEmpty(str2)) {
            return;
        }
        h = str2;
        TDLog.d("ThinkingAnalytics.SystemInformation", "#lib_version has been changed to: " + str2);
    }

    private boolean a(Context context, String str) {
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
            TDLog.w("ThinkingAnalytics.SystemInformation", "You can fix this by adding the following to your AndroidManifest.xml file:\n<uses-permission android:name=\"" + str + "\" />");
            return false;
        } catch (Exception e) {
            TDLog.w("ThinkingAnalytics.SystemInformation", e.toString());
            return true;
        }
    }

    public static e b(Context context) {
        e eVar;
        synchronized (j) {
            if (i == null) {
                i = new e(context, null);
            }
            eVar = i;
        }
        return eVar;
    }

    private static String b(Context context, boolean z) {
        StorageManager storageManager = (StorageManager) context.getSystemService("storage");
        try {
            Class<?> cls = Class.forName("android.os.storage.StorageVolume");
            Method method = storageManager.getClass().getMethod("getVolumeList", new Class[0]);
            Method method2 = Build.VERSION.SDK_INT < 30 ? cls.getMethod("getPath", new Class[0]) : cls.getMethod("getDirectory", new Class[0]);
            Method method3 = cls.getMethod("isRemovable", new Class[0]);
            Object objInvoke = method.invoke(storageManager, new Object[0]);
            int length = Array.getLength(objInvoke);
            for (int i2 = 0; i2 < length; i2++) {
                Object obj = Array.get(objInvoke, i2);
                String absolutePath = Build.VERSION.SDK_INT < 30 ? (String) method2.invoke(obj, new Object[0]) : ((File) method2.invoke(obj, new Object[0])).getAbsolutePath();
                if (z == ((Boolean) method3.invoke(obj, new Object[0])).booleanValue()) {
                    return absolutePath;
                }
            }
            return null;
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            return null;
        } catch (IllegalAccessException e2) {
            e2.printStackTrace();
            return null;
        } catch (NoSuchMethodException e3) {
            e3.printStackTrace();
            return null;
        } catch (InvocationTargetException e4) {
            e4.printStackTrace();
            return null;
        } catch (Exception e5) {
            e5.printStackTrace();
            return null;
        }
    }

    private Map<String, Object> c(Context context) {
        HashMap map = new HashMap();
        if (!TDPresetProperties.disableList.contains("#lib")) {
            map.put("#lib", g);
        }
        if (!TDPresetProperties.disableList.contains("#lib_version")) {
            map.put("#lib_version", h);
        }
        if (this.b != null && !TDPresetProperties.disableList.contains("#install_time")) {
            map.put("#install_time", new n(new Date(this.f97a), this.b).b());
        }
        Map<String, Object> presetProperties = TDPresetModel.getInstance(context).getPresetProperties();
        for (String str : presetProperties.keySet()) {
            map.put(str, presetProperties.get(str));
        }
        return Collections.unmodifiableMap(map);
    }

    static String g() {
        return g;
    }

    static String h() {
        return h;
    }

    public String a(Context context) {
        ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
        ActivityManager.MemoryInfo memoryInfo = new ActivityManager.MemoryInfo();
        activityManager.getMemoryInfo(memoryInfo);
        long j2 = memoryInfo.totalMem;
        return q.a(((memoryInfo.availMem / 1024.0d) / 1024.0d) / 1024.0d) + "/" + q.a(((j2 / 1024.0d) / 1024.0d) / 1024.0d);
    }

    public String a(Context context, boolean z) {
        if (TextUtils.isEmpty(this.f)) {
            this.f = b(context, z);
        }
        if (TextUtils.isEmpty(this.f)) {
            return "0";
        }
        try {
            StatFs statFs = new StatFs(new File(this.f).getPath());
            long blockCountLong = statFs.getBlockCountLong();
            long blockSizeLong = statFs.getBlockSizeLong();
            return q.a((((statFs.getAvailableBlocksLong() * blockSizeLong) / 1024.0d) / 1024.0d) / 1024.0d) + "/" + q.a((((blockCountLong * blockSizeLong) / 1024.0d) / 1024.0d) / 1024.0d);
        } catch (Exception unused) {
            return "0";
        }
    }

    public JSONObject a() {
        if (this.c == null) {
            return new JSONObject();
        }
        JSONObject jSONObject = new JSONObject(this.c);
        jSONObject.remove("#lib");
        jSONObject.remove("#lib_version");
        return jSONObject;
    }

    public String b() {
        return TDPresetModel.getInstance(this.d).getAppVersionName();
    }

    public String c() {
        return TDPresetModel.getInstance(this.d).getCurrentNetworkType();
    }

    public String d() {
        return TDPresetModel.getInstance(this.d).getDeviceId();
    }

    public Map<String, Object> e() {
        return this.c;
    }

    boolean f() {
        if (!this.e) {
            return false;
        }
        try {
            NetworkInfo activeNetworkInfo = ((ConnectivityManager) this.d.getSystemService("connectivity")).getActiveNetworkInfo();
            return activeNetworkInfo != null && activeNetworkInfo.isConnected();
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }
}
