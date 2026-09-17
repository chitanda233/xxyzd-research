package cn.thinkingdata.core.preset;

import android.content.Context;
import android.text.TextUtils;
import cn.thinkingdata.core.utils.ProcessUtil;
import cn.thinkingdata.core.utils.TDCommonUtil;
import cn.thinkingdata.core.utils.TDLog;
import com.alipay.sdk.m.d.a;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/* JADX INFO: loaded from: classes.dex */
public class TDPresetUtils {
    public static final String COMMAND_HARMONY_OS_VERSION = "getprop hw_sc.build.platform.version";
    public static final String KEY_APP_VERSION = "#app_version";
    public static final String KEY_BUNDLE_ID = "#bundle_id";
    public static final String KEY_CARRIER = "#carrier";
    public static final String KEY_DEVICE_ID = "#device_id";
    public static final String KEY_DEVICE_MODEL = "#device_model";
    public static final String KEY_DEVICE_TYPE = "#device_type";
    public static final String KEY_MANUFACTURER = "#manufacturer";
    public static final String KEY_NETWORK_TYPE = "#network_type";
    public static final String KEY_OS = "#os";
    public static final String KEY_OS_VERSION = "#os_version";
    public static final String KEY_SCREEN_HEIGHT = "#screen_height";
    public static final String KEY_SCREEN_WIDTH = "#screen_width";
    public static final String KEY_SIMULATOR = "#simulator";
    public static final String KEY_SYSTEM_LANGUAGE = "#system_language";

    public static String exec(String str) {
        Throwable th;
        BufferedReader bufferedReader;
        InputStreamReader inputStreamReader;
        try {
            inputStreamReader = new InputStreamReader(Runtime.getRuntime().exec(str).getInputStream());
            try {
                bufferedReader = new BufferedReader(inputStreamReader);
                try {
                    StringBuilder sb = new StringBuilder();
                    while (true) {
                        String line = bufferedReader.readLine();
                        if (line == null) {
                            break;
                        }
                        sb.append(line);
                    }
                    String string = sb.toString();
                    try {
                        bufferedReader.close();
                    } catch (Throwable th2) {
                        TDLog.i("TDExec", th2.getMessage());
                    }
                    try {
                        inputStreamReader.close();
                    } catch (IOException e) {
                        TDLog.i("TDExec", e.getMessage());
                    }
                    return string;
                } catch (Throwable th3) {
                    th = th3;
                    try {
                        TDLog.i("TDExec", th.getMessage());
                        return null;
                    } finally {
                        if (bufferedReader != null) {
                            try {
                                bufferedReader.close();
                            } catch (Throwable th4) {
                                TDLog.i("TDExec", th4.getMessage());
                            }
                        }
                        if (inputStreamReader != null) {
                            try {
                                inputStreamReader.close();
                            } catch (IOException e2) {
                                TDLog.i("TDExec", e2.getMessage());
                            }
                        }
                    }
                }
            } catch (Throwable th5) {
                th = th5;
                bufferedReader = null;
            }
        } catch (Throwable th6) {
            th = th6;
            bufferedReader = null;
            inputStreamReader = null;
        }
    }

    public static String getCurrentProcessName(Context context) {
        try {
            return ProcessUtil.getCurrentProcessName(context);
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static String getDeviceType(Context context) {
        return (context.getResources().getConfiguration().screenLayout & 15) < 3 ? "Phone" : "Tablet";
    }

    public static String getHarmonyOSVersion() {
        if (!isHarmonyOS()) {
            return null;
        }
        String prop = TDCommonUtil.getProp(a.b, "");
        return TextUtils.isEmpty(prop) ? exec(COMMAND_HARMONY_OS_VERSION) : prop;
    }

    public static String getRandomHEXValue(int i) {
        double dRandom;
        double d;
        char c;
        StringBuilder sb = new StringBuilder();
        for (int i2 = 0; i2 < i; i2++) {
            int iRandom = (int) (Math.random() * 2.0d);
            if (iRandom != 0) {
                if (iRandom != 1) {
                    c = 0;
                } else {
                    dRandom = Math.random() * 6.0d;
                    d = 97.0d;
                }
                sb.append(c);
            } else {
                dRandom = Math.random() * 10.0d;
                d = 48.0d;
            }
            c = (char) (dRandom + d);
            sb.append(c);
        }
        return sb.toString();
    }

    public static boolean isHarmonyOS() {
        try {
            Class<?> cls = Class.forName("com.huawei.system.BuildEx");
            Object objInvoke = cls.getMethod("getOsBrand", new Class[0]).invoke(cls, new Object[0]);
            if (objInvoke == null) {
                return false;
            }
            return "harmony".equalsIgnoreCase(objInvoke.toString());
        } catch (Throwable unused) {
            return false;
        }
    }
}
