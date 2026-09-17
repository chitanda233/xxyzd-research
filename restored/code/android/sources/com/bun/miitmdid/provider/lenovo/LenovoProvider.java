package com.bun.miitmdid.provider.lenovo;

import a.f.b.a;
import android.content.Context;
import android.os.RemoteException;
import com.bun.miitmdid.provider.BaseProvider;
import com.netease.nis.sdkwrapper.Utils;

/* JADX INFO: loaded from: classes.dex */
public class LenovoProvider extends BaseProvider {
    public static final String TAG = "SDK call Lenovo: ";
    public Context context;
    public a openDeviceId = new a();

    public LenovoProvider(Context context) {
        this.context = context;
    }

    public static /* synthetic */ boolean access$002(LenovoProvider lenovoProvider, boolean z) {
        Object[] objArr = new Object[5];
        objArr[1] = lenovoProvider;
        objArr[2] = Boolean.valueOf(z);
        objArr[3] = 64;
        objArr[4] = 1594371206340L;
        return ((Boolean) Utils.rL(objArr)).booleanValue();
    }

    public static /* synthetic */ String access$102(LenovoProvider lenovoProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = lenovoProvider;
        objArr[2] = str;
        objArr[3] = 65;
        objArr[4] = 1594371206341L;
        return (String) Utils.rL(objArr);
    }

    public static /* synthetic */ String access$202(LenovoProvider lenovoProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = lenovoProvider;
        objArr[2] = str;
        objArr[3] = 66;
        objArr[4] = 1594371206342L;
        return (String) Utils.rL(objArr);
    }

    public static /* synthetic */ String access$302(LenovoProvider lenovoProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = lenovoProvider;
        objArr[2] = str;
        objArr[3] = 67;
        objArr[4] = 1594371206343L;
        return (String) Utils.rL(objArr);
    }

    @Override // com.bun.miitmdid.provider.BaseProvider
    public void doStart() {
        Utils.rL(new Object[]{this, 68, 1594371206344L});
    }

    @Override // com.bun.miitmdid.interfaces.IdSupplier
    public boolean isSupported() {
        return ((Boolean) Utils.rL(new Object[]{this, 69, 1594371206345L})).booleanValue();
    }

    /* JADX INFO: renamed from: com.bun.miitmdid.provider.lenovo.LenovoProvider$1, reason: invalid class name */
    public class AnonymousClass1 implements a.b<String> {
        public AnonymousClass1() {
        }

        /* JADX WARN: Code duplicated, block: B:30:0x005a  */
        @Override // a.f.b.a.b
        public void serviceConnected(String str, a aVar) {
            boolean zIsSupport;
            String oaid;
            String vaid;
            LenovoProvider lenovoProvider = LenovoProvider.this;
            aVar.getClass();
            try {
                zIsSupport = aVar.b != null ? aVar.b.isSupport() : false;
            } catch (RemoteException unused) {
            }
            LenovoProvider.access$002(lenovoProvider, zIsSupport);
            if (aVar.f31a == null) {
                throw new IllegalArgumentException("Context is null, must be new OpenDeviceId first");
            }
            String aaid = null;
            try {
                oaid = aVar.b != null ? aVar.b.getOAID() : null;
            } catch (RemoteException e) {
                e.printStackTrace();
            }
            Context context = aVar.f31a;
            if (context == null) {
                throw new IllegalArgumentException("Context is null, must be new OpenDeviceId first");
            }
            String packageName = context.getPackageName();
            String str2 = "liufeng, getVAID package：" + packageName;
            if (packageName == null || packageName.equals("")) {
                vaid = null;
            } else {
                try {
                    if (aVar.b != null) {
                        vaid = aVar.b.getVAID(packageName);
                    } else {
                        vaid = null;
                    }
                } catch (RemoteException e2) {
                    e2.printStackTrace();
                }
            }
            Context context2 = aVar.f31a;
            if (context2 == null) {
                throw new IllegalArgumentException("Context is null, must be new OpenDeviceId first");
            }
            String packageName2 = context2.getPackageName();
            String str3 = "liufeng, getAAID package：" + packageName2;
            if (packageName2 != null && !packageName2.equals("")) {
                try {
                    if (aVar.b != null && (((aaid = aVar.b.getAAID(packageName2)) == null || "".equals(aaid)) && aVar.b.a(packageName2))) {
                        aaid = aVar.b.getAAID(packageName2);
                    }
                } catch (RemoteException unused2) {
                }
            }
            LenovoProvider lenovoProvider2 = LenovoProvider.this;
            if (oaid == null) {
                oaid = "";
            }
            LenovoProvider.access$102(lenovoProvider2, oaid);
            LenovoProvider lenovoProvider3 = LenovoProvider.this;
            if (vaid == null) {
                vaid = "";
            }
            LenovoProvider.access$202(lenovoProvider3, vaid);
            LenovoProvider.access$302(LenovoProvider.this, aaid != null ? aaid : "");
            LenovoProvider.this.returnCallResult();
        }
    }
}
