package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.os.Debug;
import android.provider.Settings;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import java.io.ByteArrayInputStream;
import java.security.cert.CertificateFactory;
import java.security.cert.X509Certificate;
import java.util.ArrayList;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Betelnut {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final Wild f3824a = new Wild();

    public static int b(Context context) {
        Intent intentRegisterReceiver = null;
        try {
            intentRegisterReceiver = context.registerReceiver(null, new IntentFilter("android.intent.action.BATTERY_CHANGED"));
        } catch (Throwable unused) {
        }
        if (intentRegisterReceiver == null) {
            return 0;
        }
        int intExtra = intentRegisterReceiver.getIntExtra("status", -1);
        if (intExtra != 2 && intExtra != 5) {
            return 1;
        }
        int intExtra2 = intentRegisterReceiver.getIntExtra("plugged", -1);
        if (intExtra2 == 2) {
            return 3;
        }
        return intExtra2 == 1 ? 2 : 0;
    }

    public static String c(Context context) {
        String string;
        Wild wild = f3824a;
        synchronized (wild) {
            String str = (String) wild.a();
            if (str != null) {
                return str;
            }
            StringBuilder sb = new StringBuilder();
            try {
                TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                sb.append(telephonyManager.getSimState());
                int phoneCount = telephonyManager.getPhoneCount();
                sb.append(",");
                sb.append(phoneCount);
                if (phoneCount > 1) {
                    sb.append(",");
                    for (int i = 0; i < phoneCount; i++) {
                        if (i > 0) {
                            sb.append(com.alipay.sdk.m.y.l.b);
                        }
                        sb.append(telephonyManager.getSimState(i));
                    }
                }
                string = sb.toString();
            } catch (Throwable unused) {
                string = sb.toString();
            }
            f3824a.a(string, 0L);
            return string;
        }
    }

    public static int d(Context context) {
        return 0;
    }

    public static String e(Context context) {
        ByteArrayInputStream byteArrayInputStream;
        String strA;
        ArrayList arrayList = new ArrayList();
        String packageName = context.getPackageName();
        if (!TextUtils.isEmpty(packageName)) {
            try {
                PackageManager packageManager = context.getPackageManager();
                byteArrayInputStream = new ByteArrayInputStream(packageManager.getPackageInfo(packageManager.getPackagesForUid(context.getPackageManager().getApplicationInfo(packageName, 0).uid)[0], 64).signatures[0].toByteArray());
                try {
                    strA = Teazle.a(Berry.a(((X509Certificate) CertificateFactory.getInstance("X.509").generateCertificate(byteArrayInputStream)).getEncoded()));
                    try {
                        byteArrayInputStream.close();
                    } catch (Throwable unused) {
                    }
                } catch (Throwable unused2) {
                    if (byteArrayInputStream != null) {
                        try {
                            byteArrayInputStream.close();
                        } catch (Throwable unused3) {
                        }
                    }
                    strA = "";
                }
            } catch (Throwable unused4) {
                byteArrayInputStream = null;
            }
            Cinterface cinterface = new Cinterface();
            cinterface.f3939a = f.f3927a + f.b;
            cinterface.b = packageName + "_" + strA;
            arrayList.add(cinterface);
        }
        return !arrayList.isEmpty() ? ((Cinterface) arrayList.get(0)).b : "";
    }

    public static int a(Context context) {
        boolean z = false;
        int iA = Cthrow.a(Cthrow.a(0, 0, Settings.Secure.getInt(context.getContentResolver(), "adb_enabled", 0) > 0), 1, Settings.Secure.getInt(context.getContentResolver(), "development_settings_enabled", 0) > 0);
        try {
            if ((context.getApplicationInfo().flags & 2) > 0) {
                z = true;
            }
        } catch (Throwable unused) {
        }
        return Cthrow.a(Cthrow.a(iA, 2, z), 3, Debug.isDebuggerConnected());
    }

    public static String a() {
        Context context;
        StringBuilder sb = new StringBuilder();
        try {
            synchronized (Ccatch.class) {
                context = Ccatch.f3917a;
            }
            Virgo virgoA = Bagasse.a(context);
            for (int i = 0; i < virgoA.f3903a.size(); i++) {
                if (sb.length() > 0) {
                    sb.append(",");
                }
                Locale locale = virgoA.f3903a.get(i);
                if (locale != null) {
                    sb.append(locale.getLanguage()).append("-").append(locale.getCountry());
                }
            }
        } catch (Throwable unused) {
        }
        return sb.toString();
    }
}
