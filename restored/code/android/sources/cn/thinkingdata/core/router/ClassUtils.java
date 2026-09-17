package cn.thinkingdata.core.router;

import android.content.Context;
import android.content.SharedPreferences;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.util.Log;
import cn.thinkingdata.core.utils.pool.DefaultPoolExecutor;
import dalvik.system.DexFile;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Enumeration;
import java.util.HashSet;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes.dex */
public class ClassUtils {
    private static final String EXTRACTED_NAME_EXT = ".classes";
    private static final String EXTRACTED_SUFFIX = ".zip";
    private static final String KEY_DEX_NUMBER = "dex.number";
    private static final String PREFS_FILE = "multidex.version";
    private static final String SECONDARY_FOLDER_NAME = "code_cache" + File.separator + "secondary-dexes";
    private static final int VM_WITH_MULTIDEX_VERSION_MAJOR = 2;
    private static final int VM_WITH_MULTIDEX_VERSION_MINOR = 1;

    public static void getFileNameByPackageName(Context context, final String str, final LogisticsCenter.OnLoadPluginCallBack onLoadPluginCallBack) {
        for (final String str2 : getSourcePaths(context)) {
            final HashSet hashSet = new HashSet();
            DefaultPoolExecutor.getInstance().execute(new Runnable() { // from class: cn.thinkingdata.core.router.ClassUtils.1
                @Override // java.lang.Runnable
                public void run() {
                    Throwable th;
                    DexFile dexFileLoadDex;
                    try {
                        dexFileLoadDex = str2.endsWith(ClassUtils.EXTRACTED_SUFFIX) ? DexFile.loadDex(str2, str2 + ".tmp", 0) : new DexFile(str2);
                        try {
                            Enumeration<String> enumerationEntries = dexFileLoadDex.entries();
                            while (enumerationEntries.hasMoreElements()) {
                                String strNextElement = enumerationEntries.nextElement();
                                if (strNextElement.startsWith(str)) {
                                    hashSet.add(strNextElement);
                                }
                            }
                            onLoadPluginCallBack.onPluginLoadSuccess(hashSet);
                            if (dexFileLoadDex == null) {
                            }
                        } catch (Throwable th2) {
                            th = th2;
                            try {
                                Log.e("TRouter", "Scan map file in dex files made error.", th);
                            } finally {
                                if (dexFileLoadDex != null) {
                                    try {
                                        dexFileLoadDex.close();
                                    } catch (Throwable unused) {
                                    }
                                }
                            }
                        }
                    } catch (Throwable th3) {
                        th = th3;
                        dexFileLoadDex = null;
                    }
                }
            });
        }
    }

    private static SharedPreferences getMultiDexPreferences(Context context) {
        return context.getSharedPreferences(PREFS_FILE, 4);
    }

    public static List<String> getSourcePaths(Context context) throws PackageManager.NameNotFoundException, IOException {
        ApplicationInfo applicationInfo = context.getPackageManager().getApplicationInfo(context.getPackageName(), 0);
        File file = new File(applicationInfo.sourceDir);
        ArrayList arrayList = new ArrayList();
        arrayList.add(applicationInfo.sourceDir);
        String str = file.getName() + EXTRACTED_NAME_EXT;
        if (!isVMMultidexCapable()) {
            int i = getMultiDexPreferences(context).getInt(KEY_DEX_NUMBER, 1);
            File file2 = new File(applicationInfo.dataDir, SECONDARY_FOLDER_NAME);
            for (int i2 = 2; i2 <= i; i2++) {
                File file3 = new File(file2, str + i2 + EXTRACTED_SUFFIX);
                if (!file3.isFile()) {
                    throw new IOException("Missing extracted secondary dex file '" + file3.getPath() + "'");
                }
                arrayList.add(file3.getAbsolutePath());
            }
        }
        arrayList.addAll(tryLoadInstantRunDexFile(applicationInfo));
        return arrayList;
    }

    private static boolean isVMMultidexCapable() {
        boolean z = false;
        try {
            if (!isYunOS()) {
                String property = System.getProperty("java.vm.version");
                if (property != null) {
                    Matcher matcher = Pattern.compile("(\\d+)\\.(\\d+)(\\.\\d+)?").matcher(property);
                    if (matcher.matches()) {
                        int i = Integer.parseInt(matcher.group(1));
                        int i2 = Integer.parseInt(matcher.group(2));
                        if (i > 2 || (i == 2 && i2 >= 1)) {
                            z = true;
                        }
                    }
                }
            } else if (Integer.valueOf(System.getProperty("ro.build.version.sdk")).intValue() >= 21) {
                z = true;
            }
        } catch (NumberFormatException | Exception unused) {
        }
        return z;
    }

    private static boolean isYunOS() {
        try {
            String property = System.getProperty("ro.yunos.version");
            String property2 = System.getProperty("java.vm.name");
            return (property2 != null && property2.toLowerCase().contains("lemur")) || (property != null && property.trim().length() > 0);
        } catch (Exception unused) {
            return false;
        }
    }

    private static List<String> tryLoadInstantRunDexFile(ApplicationInfo applicationInfo) {
        ArrayList arrayList = new ArrayList();
        String[] strArr = applicationInfo.splitSourceDirs;
        if (strArr != null) {
            arrayList.addAll(Arrays.asList(strArr));
        } else {
            try {
                File file = new File((String) Class.forName("com.android.tools.fd.runtime.Paths").getMethod("getDexFileDirectory", String.class).invoke(null, applicationInfo.packageName));
                if (file.exists() && file.isDirectory()) {
                    for (File file2 : file.listFiles()) {
                        if (file2 != null && file2.exists() && file2.isFile() && file2.getName().endsWith(".dex")) {
                            arrayList.add(file2.getAbsolutePath());
                        }
                    }
                }
            } catch (Exception unused) {
            }
        }
        return arrayList;
    }
}
