package a.b.a;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.pm.PackageManager;
import android.content.pm.Signature;
import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Looper;
import android.os.Parcel;
import android.os.RemoteException;
import android.text.TextUtils;
import com.alipay.sdk.m.y.c;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import kotlin.UByte;

/* JADX INFO: loaded from: classes.dex */
public interface a extends IInterface {

    /* JADX INFO: renamed from: a.b.a.a$a, reason: collision with other inner class name */
    public static abstract class AbstractBinderC0002a extends Binder implements a {

        /* JADX INFO: renamed from: a.b.a.a$a$a, reason: collision with other inner class name */
        public static class C0003a implements a {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f16a;

            public C0003a(IBinder iBinder) {
                this.f16a = iBinder;
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f16a;
            }
        }

        public static a a(IBinder iBinder) {
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.heytap.openid.IOpenID");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof a)) ? new C0003a(iBinder) : (a) iInterfaceQueryLocalInterface;
        }
    }

    public class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public a f17a = null;
        public String b = null;
        public String c = null;
        public final Object d = new Object();
        public ServiceConnection e = new ServiceConnectionC0004a();

        /* JADX INFO: renamed from: a.b.a.a$b$a, reason: collision with other inner class name */
        public class ServiceConnectionC0004a implements ServiceConnection {
            public ServiceConnectionC0004a() {
            }

            @Override // android.content.ServiceConnection
            public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
                b.this.f17a = AbstractBinderC0002a.a(iBinder);
                synchronized (b.this.d) {
                    b.this.d.notify();
                }
            }

            @Override // android.content.ServiceConnection
            public void onServiceDisconnected(ComponentName componentName) {
                b.this.f17a = null;
            }
        }

        /* JADX INFO: renamed from: a.b.a.a$b$b, reason: collision with other inner class name */
        public static class C0005b {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public static final b f19a = new b();
        }

        public synchronized String a(Context context, String str) {
            String str2 = "getOpenID:" + str;
            if (Looper.myLooper() == Looper.getMainLooper()) {
                return "";
            }
            if (this.f17a != null) {
                try {
                    return b(context, str);
                } catch (RemoteException unused) {
                    return "";
                }
            }
            a(context);
            if (this.f17a == null) {
                return "";
            }
            try {
                return b(context, str);
            } catch (RemoteException unused2) {
                return "";
            }
        }

        public final void a(Context context) {
            Intent intent = new Intent();
            intent.setComponent(new ComponentName("com.heytap.openid", "com.heytap.openid.IdentifyService"));
            intent.setAction("action.com.heytap.openid.OPEN_ID_SERVICE");
            if (context.bindService(intent, this.e, 1)) {
                synchronized (this.d) {
                    try {
                        this.d.wait(c.f378a);
                    } catch (InterruptedException unused) {
                    }
                }
            }
        }

        public final String b(Context context, String str) {
            Signature[] signatureArr;
            if (TextUtils.isEmpty(this.b)) {
                this.b = context.getPackageName();
            }
            if (TextUtils.isEmpty(this.c)) {
                String string = null;
                try {
                    signatureArr = context.getPackageManager().getPackageInfo(this.b, 64).signatures;
                } catch (PackageManager.NameNotFoundException e) {
                    e.printStackTrace();
                    signatureArr = null;
                }
                if (signatureArr != null && signatureArr.length > 0) {
                    byte[] byteArray = signatureArr[0].toByteArray();
                    try {
                        MessageDigest messageDigest = MessageDigest.getInstance("SHA1");
                        if (messageDigest != null) {
                            byte[] bArrDigest = messageDigest.digest(byteArray);
                            StringBuilder sb = new StringBuilder();
                            for (byte b : bArrDigest) {
                                sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
                            }
                            string = sb.toString();
                        }
                    } catch (NoSuchAlgorithmException e2) {
                        e2.printStackTrace();
                    }
                }
                this.c = string;
            }
            a aVar = this.f17a;
            if (aVar == null) {
                String str2 = context.getPackageName() + ":OpenIDHelper";
                return "";
            }
            String str3 = this.b;
            String str4 = this.c;
            AbstractBinderC0002a.C0003a c0003a = (AbstractBinderC0002a.C0003a) aVar;
            Parcel parcelObtain = Parcel.obtain();
            Parcel parcelObtain2 = Parcel.obtain();
            try {
                parcelObtain.writeInterfaceToken("com.heytap.openid.IOpenID");
                parcelObtain.writeString(str3);
                parcelObtain.writeString(str4);
                parcelObtain.writeString(str);
                c0003a.f16a.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                String string2 = parcelObtain2.readString();
                parcelObtain2.recycle();
                parcelObtain.recycle();
                return TextUtils.isEmpty(string2) ? "" : string2;
            } catch (Throwable th) {
                parcelObtain2.recycle();
                parcelObtain.recycle();
                throw th;
            }
        }
    }
}
