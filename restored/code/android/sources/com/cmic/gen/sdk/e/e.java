package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.IBinder;
import android.os.Parcel;
import android.provider.Settings;
import android.text.TextUtils;
import com.huawei.hms.ads.identifier.AdvertisingIdClient;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: HuaWeiOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class e extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2103a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.e.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                e.this.b.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (Exception unused) {
            }
        }
    };

    e(Context context) {
        this.f2103a = context;
    }

    private static boolean a(String str) {
        if (TextUtils.isEmpty(str)) {
            return true;
        }
        return str.replaceAll("0", "").replaceAll("-", "").isEmpty();
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        String string;
        try {
            String string2 = Settings.Global.getString(this.f2103a.getContentResolver(), AdvertisingIdClient.SETTINGS_AD_ID);
            if (!a(string2)) {
                return string2;
            }
            Intent intent = new Intent("com.uodis.opendevice.OPENIDS_SERVICE");
            intent.setPackage(a(this.f2103a));
            if (this.f2103a.bindService(intent, this.c, 1)) {
                try {
                    IBinder iBinderPoll = this.b.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
                    if (iBinderPoll == null) {
                        this.f2103a.unbindService(this.c);
                        return "";
                    }
                    Parcel parcelObtain = Parcel.obtain();
                    Parcel parcelObtain2 = Parcel.obtain();
                    try {
                        parcelObtain.writeInterfaceToken(com.alipay.sdk.m.d.b.f273a);
                        iBinderPoll.transact(1, parcelObtain, parcelObtain2, 0);
                        parcelObtain2.readException();
                        string = parcelObtain2.readString();
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                    } catch (Throwable th) {
                        try {
                            th.printStackTrace();
                            parcelObtain.recycle();
                            parcelObtain2.recycle();
                            string = "";
                        } catch (Throwable th2) {
                            parcelObtain.recycle();
                            parcelObtain2.recycle();
                            throw th2;
                        }
                    }
                    this.f2103a.unbindService(this.c);
                    return string;
                } catch (Exception unused) {
                    this.f2103a.unbindService(this.c);
                } catch (Throwable th3) {
                    this.f2103a.unbindService(this.c);
                    throw th3;
                }
            }
            return "";
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static String a(Context context) {
        if (a(context, "com.huawei.hwid")) {
            return "com.huawei.hwid";
        }
        String str = "com.huawei.hms";
        if (!a(context, "com.huawei.hms")) {
            str = "com.huawei.hwid.tv";
            if (!a(context, "com.huawei.hwid.tv")) {
                return "com.huawei.hwid";
            }
        }
        return str;
    }

    private static boolean a(Context context, String str) {
        return b(context, str) != null;
    }

    private static PackageInfo b(Context context, String str) {
        if (!TextUtils.isEmpty(str) && context != null) {
            try {
                PackageManager packageManager = context.getPackageManager();
                if (packageManager != null) {
                    return packageManager.getPackageInfo(str, 128);
                }
            } catch (Throwable unused) {
            }
        }
        return null;
    }
}
