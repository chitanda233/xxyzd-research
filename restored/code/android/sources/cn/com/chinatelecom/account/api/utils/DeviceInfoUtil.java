package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;
import android.os.Process;
import android.text.TextUtils;
import android.webkit.WebSettings;
import android.webkit.WebView;
import com.baidu.mobads.sdk.internal.bz;
import com.sigmob.sdk.archives.tar.e;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.InputStreamReader;
import java.lang.reflect.Method;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.SocketException;
import java.security.MessageDigest;
import java.util.Enumeration;
import java.util.HashSet;
import java.util.UUID;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes.dex */
public class DeviceInfoUtil {
    private static final String key = "Dev8k03JiceI1OQPLiNfoi2kenm281x2qw";
    private static final String tag = "cn.com.chinatelecom.account.api.utils.DeviceInfoUtil";
    private static String userAgent = "";
    private static final Pattern IPV4_REGEX = Pattern.compile("^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$");
    private static String mDeviceId = "";

    public static synchronized String getUserAgentInstance(Context context) {
        if (TextUtils.isEmpty(userAgent) && context != null) {
            try {
                userAgent = WebSettings.getDefaultUserAgent(context);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return userAgent;
    }

    /* JADX INFO: renamed from: cn.com.chinatelecom.account.api.utils.DeviceInfoUtil$1, reason: invalid class name */
    class AnonymousClass1 implements Runnable {
        final /* synthetic */ Context val$mContext;

        AnonymousClass1(Context context) {
            this.val$mContext = context;
        }

        @Override // java.lang.Runnable
        public void run() {
            if (this.val$mContext != null) {
                DeviceInfoUtil.userAgent = new WebView(this.val$mContext).getSettings().getUserAgentString();
            }
        }
    }

    public static String getISPType(String str) {
        if (TextUtils.isEmpty(str)) {
            return "";
        }
        if (str.startsWith("46000") || str.startsWith("46002") || str.startsWith("46004") || str.startsWith("46007")) {
            return "cm";
        }
        if (str.startsWith("46003") || str.startsWith("46005") || str.startsWith("46011")) {
            return "ct";
        }
        return (str.startsWith("46001") || str.startsWith("46006") || str.startsWith("46009")) ? "cu" : "";
    }

    public static String getSysVersion() {
        try {
            return "android" + Build.VERSION.RELEASE;
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static String getLocalIpAddr() {
        String hostAddress = "";
        try {
            Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
            while (networkInterfaces.hasMoreElements()) {
                Enumeration<InetAddress> inetAddresses = networkInterfaces.nextElement().getInetAddresses();
                while (inetAddresses.hasMoreElements()) {
                    InetAddress inetAddressNextElement = inetAddresses.nextElement();
                    if (!inetAddressNextElement.isLoopbackAddress()) {
                        hostAddress = inetAddressNextElement.getHostAddress();
                    }
                }
            }
        } catch (SocketException e) {
            e.printStackTrace();
        }
        return hostAddress;
    }

    public static PackageInfo getPackageInfo(Context context, String str) {
        if (TextUtils.isEmpty(str) && context == null) {
            return null;
        }
        try {
            return context.getPackageManager().getPackageInfo(str, 64);
        } catch (PackageManager.NameNotFoundException e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String getAppSelfVersion(Context context) {
        return getAppSelfVersion(getPackageInfo(context, context.getPackageName()));
    }

    public static String getAppSelfVersion(PackageInfo packageInfo) {
        if (packageInfo == null) {
            return "";
        }
        String str = packageInfo.versionName;
        return !TextUtils.isEmpty(str) ? str : "";
    }

    public static String getAppName(Context context) {
        try {
            PackageManager packageManager = context.getPackageManager();
            String string = packageManager.getPackageInfo(context.getPackageName(), 0).applicationInfo.loadLabel(packageManager).toString();
            return !TextUtils.isEmpty(string) ? string : "";
        } catch (PackageManager.NameNotFoundException e) {
            e.printStackTrace();
            return "";
        } catch (Exception e2) {
            e2.printStackTrace();
            return "";
        }
    }

    public static String getApplicationMetaData(Context context, String str) {
        try {
            Bundle bundle = context.getPackageManager().getApplicationInfo(context.getPackageName(), 128).metaData;
            return (bundle == null || !bundle.containsKey(str)) ? "" : bundle.getString(str);
        } catch (PackageManager.NameNotFoundException e) {
            e.printStackTrace();
            return "";
        } catch (Exception e2) {
            e2.printStackTrace();
            return "";
        }
    }

    public static String getDeviceId(Context context) {
        if (TextUtils.isEmpty(mDeviceId)) {
            String saveDeviceId = getSaveDeviceId(context);
            mDeviceId = saveDeviceId;
            if (TextUtils.isEmpty(saveDeviceId)) {
                String strCreateDeviceId = createDeviceId(context);
                mDeviceId = strCreateDeviceId;
                saveDeviceId(context, strCreateDeviceId);
            }
        }
        return mDeviceId;
    }

    private static void saveDeviceId(Context context, String str) {
        if (TextUtils.isEmpty(str) || context == null) {
            return;
        }
        DefaultShared.putString(context, Constants.KEY_DEVICE_UUID, str);
    }

    private static String getSaveDeviceId(Context context) {
        return DefaultShared.getString(context, Constants.KEY_DEVICE_UUID, "");
    }

    private static String createDeviceId(Context context) {
        String strMD5 = MD5(UUID.randomUUID().toString() + "default");
        return TextUtils.isEmpty(strMD5) ? "default" : strMD5;
    }

    public static String getRequestId() {
        String string = UUID.randomUUID().toString();
        try {
            string = UUID.nameUUIDFromBytes((string + System.currentTimeMillis() + Math.random()).getBytes("utf8")).toString();
        } catch (Throwable th) {
            th.printStackTrace();
        }
        return !TextUtils.isEmpty(string) ? string.replace("-", "") : string;
    }

    private static String MD5(String str) {
        char[] cArr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        try {
            byte[] bytes = str.getBytes();
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            messageDigest.update(bytes);
            byte[] bArrDigest = messageDigest.digest();
            char[] cArr2 = new char[bArrDigest.length * 2];
            int i = 0;
            for (byte b : bArrDigest) {
                int i2 = i + 1;
                cArr2[i] = cArr[(b >>> 4) & 15];
                i = i2 + 1;
                cArr2[i2] = cArr[b & 15];
            }
            return new String(cArr2);
        } catch (Exception unused) {
            return null;
        }
    }

    public static boolean apRef(Object obj, String str) throws Throwable {
        Method declaredMethod = obj.getClass().getDeclaredMethod(str, new Class[0]);
        declaredMethod.setAccessible(true);
        return ((Boolean) declaredMethod.invoke(obj, new Object[0])).booleanValue();
    }

    public static StringBuffer getIpList() throws Throwable {
        StringBuffer stringBuffer = new StringBuffer();
        Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
        while (networkInterfaces.hasMoreElements()) {
            NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
            String name = networkInterfaceNextElement.getName();
            if (name == null || (!name.contains("wlan") && !name.equals("eth0"))) {
                Enumeration<InetAddress> inetAddresses = networkInterfaceNextElement.getInetAddresses();
                while (inetAddresses.hasMoreElements()) {
                    InetAddress inetAddressNextElement = inetAddresses.nextElement();
                    if (!inetAddressNextElement.isLoopbackAddress() && !inetAddressNextElement.isLinkLocalAddress()) {
                        String hostAddress = inetAddressNextElement.getHostAddress();
                        if (!TextUtils.isEmpty(hostAddress)) {
                            if (stringBuffer.length() > 0) {
                                stringBuffer.append(",");
                            }
                            stringBuffer.append(hostAddress);
                        }
                    }
                }
            }
        }
        return stringBuffer;
    }

    public static boolean isIpv4Addr(String str) {
        return str != null && IPV4_REGEX.matcher(str).matches();
    }

    public static boolean isRoot() throws Throwable {
        String strDe = Xor.de(new byte[]{67, 31, 21, 31, 24, 9, 1, 67, 14, 5, 2, 67, 31, 25});
        String strDe2 = Xor.de(new byte[]{67, 31, 21, 31, 24, 9, 1, 67, 20, 14, 5, 2, 67, 31, 25});
        if (new File(strDe).exists() && isCanExecute(strDe)) {
            return true;
        }
        return new File(strDe2).exists() && isCanExecute(strDe2);
    }

    private static boolean isCanExecute(String str) throws Throwable {
        char cCharAt;
        Process processExec = null;
        try {
            processExec = Runtime.getRuntime().exec("ls -l " + str);
            String line = new BufferedReader(new InputStreamReader(processExec.getInputStream())).readLine();
            if (line == null || line.length() < 4 || !((cCharAt = line.charAt(3)) == 's' || cCharAt == 'x')) {
            }
            if (processExec == null) {
                return true;
            }
            processExec.destroy();
            return true;
        } finally {
            if (processExec != null) {
                processExec.destroy();
            }
        }
    }

    public static boolean isProxy(Context context) throws Throwable {
        String strDe = Xor.de(new byte[]{4, 24, 24, 28, 66, 28, 30, 3, 20, 21, 36, 3, 31, 24});
        String strDe2 = Xor.de(new byte[]{4, 24, 24, 28, 66, 28, 30, 3, 20, 21, 60, 3, 30, 24});
        String property = System.getProperty(strDe);
        String property2 = System.getProperty(strDe2);
        if (property2 == null) {
            property2 = "-1";
        }
        return (TextUtils.isEmpty(property) || Integer.parseInt(property2) == -1) ? false : true;
    }

    public static boolean isVpn() throws Throwable {
        Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
        if (networkInterfaces == null) {
            return false;
        }
        while (networkInterfaces.hasMoreElements()) {
            NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
            if (networkInterfaceNextElement.isUp() && !networkInterfaceNextElement.getInterfaceAddresses().isEmpty()) {
                String strDe = Xor.de(new byte[]{24, 25, 2, 92});
                String strDe2 = Xor.de(new byte[]{28, 28, 28, 92});
                if (strDe.equals(networkInterfaceNextElement.getName()) || strDe2.equals(networkInterfaceNextElement.getName())) {
                    return true;
                }
            }
        }
        return false;
    }

    public static boolean isHook(Context context) throws Throwable {
        return findHookAppName(context) || findHookAppFile(context) || findHookStack(context);
    }

    /* JADX WARN: Code restructure failed: missing block: B:40:0x01dc, code lost:
    
        r0 = move-exception;
     */
    /* JADX WARN: Code restructure failed: missing block: B:41:0x01dd, code lost:
    
        r0.printStackTrace();
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public static boolean isEmu(android.content.Context r29) throws java.lang.Throwable {
        /*
            Method dump skipped, instruction units count: 551
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: cn.com.chinatelecom.account.api.utils.DeviceInfoUtil.isEmu(android.content.Context):boolean");
    }

    private static boolean findHookAppName(Context context) {
        boolean z;
        boolean z2;
        String strDe = Xor.de(new byte[]{8, 9, 66, 30, 3, 14, 26, 66, 13, 2, 8, 30, 3, 5, 8, 66, 20, 28, 3, 31, 9, 8, 66, 5, 2, 31, 24, 13, 0, 0, 9, 30});
        String strDe2 = Xor.de(new byte[]{15, 3, 1, 66, 31, 13, 25, 30, 5, 7, 66, 31, 25, 14, 31, 24, 30, 13, 24, 9});
        try {
            z = context.createPackageContext(strDe, 2) != null;
        } catch (PackageManager.NameNotFoundException unused) {
        }
        try {
            z2 = context.createPackageContext(strDe2, 2) != null;
        } catch (PackageManager.NameNotFoundException unused2) {
        }
        return z || z2;
    }

    private static boolean findHookAppFile(Context context) throws Throwable {
        Throwable th;
        BufferedReader bufferedReader;
        FileReader fileReader;
        try {
            String strDe = Xor.de(new byte[]{67, 28, 30, 3, 15, 67});
            String strDe2 = Xor.de(new byte[]{67, 1, 13, 28, 31});
            String strDe3 = Xor.de(new byte[]{15, 3, 1, 66, 31, 13, 25, 30, 5, 7, 66, 31, 25, 14, 31, 24, 30, 13, 24, 9});
            String strDe4 = Xor.de(new byte[]{e.L, 28, 3, 31, 9, 8, 46, 30, 5, 8, 11, 9, 66, 6, 13, 30});
            HashSet<String> hashSet = new HashSet();
            fileReader = new FileReader(strDe + Process.myPid() + strDe2);
            try {
                BufferedReader bufferedReader2 = new BufferedReader(fileReader);
                while (true) {
                    try {
                        String line = bufferedReader2.readLine();
                        if (line == null) {
                            break;
                        }
                        if (line.endsWith(".so") || line.endsWith(".jar")) {
                            hashSet.add(line.substring(line.lastIndexOf(" ") + 1));
                        }
                    } catch (Throwable th2) {
                        bufferedReader = bufferedReader2;
                        th = th2;
                        if (bufferedReader != null) {
                            try {
                                bufferedReader.close();
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                        }
                        if (fileReader == null) {
                            throw th;
                        }
                        try {
                            fileReader.close();
                            throw th;
                        } catch (Exception e2) {
                            e2.printStackTrace();
                            throw th;
                        }
                    }
                }
                for (String str : hashSet) {
                    if (str.contains(strDe3)) {
                        try {
                            bufferedReader2.close();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                        try {
                            fileReader.close();
                        } catch (Exception e4) {
                            e4.printStackTrace();
                        }
                        return true;
                    }
                    if (str.contains(strDe4)) {
                        try {
                            bufferedReader2.close();
                        } catch (Exception e5) {
                            e5.printStackTrace();
                        }
                        try {
                            fileReader.close();
                        } catch (Exception e6) {
                            e6.printStackTrace();
                        }
                        return true;
                    }
                }
                try {
                    bufferedReader2.close();
                } catch (Exception e7) {
                    e7.printStackTrace();
                }
                try {
                    fileReader.close();
                } catch (Exception e8) {
                    e8.printStackTrace();
                }
                return false;
            } catch (Throwable th3) {
                th = th3;
                bufferedReader = null;
            }
        } catch (Throwable th4) {
            th = th4;
            bufferedReader = null;
            fileReader = null;
        }
    }

    private static boolean findHookStack(Context context) throws Throwable {
        try {
            throw new Exception("we have exception");
        } catch (Exception e) {
            String strDe = Xor.de(new byte[]{15, 3, 1, 66, 13, 2, 8, 30, 3, 5, 8, 66, 5, 2, 24, 9, 30, 2, 13, 0, 66, 3, 31, 66, e.N, 21, 11, 3, 24, 9, 37, 2, 5, 24});
            String strDe2 = Xor.de(new byte[]{8, 9, 66, 30, 3, 14, 26, 66, 13, 2, 8, 30, 3, 5, 8, 66, 20, 28, 3, 31, 9, 8, 66, e.L, 28, 3, 31, 9, 8, 46, 30, 5, 8, 11, 9});
            String strDe3 = Xor.de(new byte[]{8, 9, 66, 30, 3, 14, 26, 66, 13, 2, 8, 30, 3, 5, 8, 66, 20, 28, 3, 31, 9, 8, 66, e.L, 28, 3, 31, 9, 8, 46, 30, 5, 8, 11, 9});
            String strDe4 = Xor.de(new byte[]{5, 2, 26, 3, 7, 9, 8});
            String strDe5 = Xor.de(new byte[]{1, 13, 5, 2});
            String strDe6 = Xor.de(new byte[]{4, 13, 2, 8, 0, 9, 36, 3, 3, 7, 9, 8, 33, 9, 24, 4, 3, 8});
            String strDe7 = Xor.de(new byte[]{15, 3, 1, 66, 31, 13, 25, 30, 5, 7, 66, 31, 25, 14, 31, 24, 30, 13, 24, 9, 66, 33, 63, 72, 94});
            int i = 0;
            for (StackTraceElement stackTraceElement : e.getStackTrace()) {
                if (stackTraceElement.getClassName().equals(strDe) && (i = i + 1) == 2) {
                    return true;
                }
                if (stackTraceElement.getClassName().equals(strDe7) && stackTraceElement.getMethodName().equals(strDe4)) {
                    return true;
                }
                if (stackTraceElement.getClassName().equals(strDe2) && stackTraceElement.getMethodName().equals(strDe5)) {
                    return true;
                }
                if (stackTraceElement.getClassName().equals(strDe3) && stackTraceElement.getMethodName().equals(strDe6)) {
                    return true;
                }
            }
            return false;
        }
    }

    private static String getProperties(Context context, String str) {
        try {
            Class<?> clsLoadClass = context.getClassLoader().loadClass(Xor.de(new byte[]{13, 2, 8, 30, 3, 5, 8, 66, 3, 31, 66, 28, 30, 3, 28, 9, 30, 24, 5, 9, 31}));
            return (String) clsLoadClass.getMethod("get", String.class).invoke(clsLoadClass, str);
        } catch (Exception unused) {
            return "";
        }
    }
}
