package com.bun.miitmdid.provider.freeme;

import a.a.a.a;
import a.a.b.b;
import a.a.b.c;
import a.a.b.d;
import android.content.Context;
import android.os.RemoteException;
import com.bun.miitmdid.provider.BaseProvider;
import com.netease.nis.sdkwrapper.Utils;

/* JADX INFO: loaded from: classes.dex */
public class FreemeProvider extends BaseProvider {
    public static final String TAG = "SDK call Freeme: ";
    public Context context;
    public String packagename;

    /* JADX INFO: renamed from: com.bun.miitmdid.provider.freeme.FreemeProvider$1, reason: invalid class name */
    public class AnonymousClass1 implements d {
        public final /* synthetic */ c val$idSupplier;

        public AnonymousClass1(c cVar) {
            this.val$idSupplier = cVar;
        }

        @Override // a.a.b.d
        public void connectSuccess(boolean z) {
            String oaid;
            String vaid;
            if (z) {
                if (((b) this.val$idSupplier).a()) {
                    FreemeProvider.access$002(FreemeProvider.this, true);
                    a aVar = ((b) this.val$idSupplier).b;
                    String aaid = null;
                    if (aVar != null) {
                        try {
                            oaid = aVar.getOAID();
                        } catch (RemoteException e) {
                            e.printStackTrace();
                            oaid = null;
                        }
                    } else {
                        oaid = null;
                    }
                    c cVar = this.val$idSupplier;
                    FreemeProvider.access$100(FreemeProvider.this);
                    a aVar2 = ((b) cVar).b;
                    if (aVar2 != null) {
                        try {
                            vaid = aVar2.getVAID();
                        } catch (RemoteException e2) {
                            e2.printStackTrace();
                            vaid = null;
                        }
                    } else {
                        vaid = null;
                    }
                    c cVar2 = this.val$idSupplier;
                    String strAccess$100 = FreemeProvider.access$100(FreemeProvider.this);
                    b bVar = (b) cVar2;
                    if (bVar.b != null) {
                        try {
                            String str = "getAAID idsSupplier:" + bVar.b;
                            String str2 = "getAAID pkgname:" + strAccess$100;
                            aaid = bVar.b.getAAID(strAccess$100);
                        } catch (RemoteException e3) {
                            e3.printStackTrace();
                        }
                    }
                    FreemeProvider freemeProvider = FreemeProvider.this;
                    if (oaid == null) {
                        oaid = "";
                    }
                    FreemeProvider.access$202(freemeProvider, oaid);
                    FreemeProvider freemeProvider2 = FreemeProvider.this;
                    if (vaid == null) {
                        vaid = "";
                    }
                    FreemeProvider.access$302(freemeProvider2, vaid);
                    FreemeProvider freemeProvider3 = FreemeProvider.this;
                    if (aaid == null) {
                        aaid = "";
                    }
                    FreemeProvider.access$402(freemeProvider3, aaid);
                    FreemeProvider.this.returnCallResult();
                }
                b bVar2 = (b) this.val$idSupplier;
                if (bVar2.b != null) {
                    bVar2.f14a.unbindService(bVar2.d);
                }
            }
        }
    }

    public FreemeProvider(Context context) {
        this.context = context;
        this.packagename = context.getPackageName();
    }

    public static /* synthetic */ boolean access$002(FreemeProvider freemeProvider, boolean z) {
        Object[] objArr = new Object[5];
        objArr[1] = freemeProvider;
        objArr[2] = Boolean.valueOf(z);
        objArr[3] = 53;
        objArr[4] = 1594371206329L;
        return ((Boolean) Utils.rL(objArr)).booleanValue();
    }

    public static /* synthetic */ String access$100(FreemeProvider freemeProvider) {
        Object[] objArr = new Object[4];
        objArr[1] = freemeProvider;
        objArr[2] = 54;
        objArr[3] = 1594371206330L;
        return (String) Utils.rL(objArr);
    }

    public static /* synthetic */ String access$202(FreemeProvider freemeProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = freemeProvider;
        objArr[2] = str;
        objArr[3] = 55;
        objArr[4] = 1594371206331L;
        return (String) Utils.rL(objArr);
    }

    public static /* synthetic */ String access$302(FreemeProvider freemeProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = freemeProvider;
        objArr[2] = str;
        objArr[3] = 56;
        objArr[4] = 1594371206332L;
        return (String) Utils.rL(objArr);
    }

    public static /* synthetic */ String access$402(FreemeProvider freemeProvider, String str) {
        Object[] objArr = new Object[5];
        objArr[1] = freemeProvider;
        objArr[2] = str;
        objArr[3] = 57;
        objArr[4] = 1594371206333L;
        return (String) Utils.rL(objArr);
    }

    @Override // com.bun.miitmdid.provider.BaseProvider
    public void doStart() {
        Utils.rL(new Object[]{this, 58, 1594371206334L});
    }

    @Override // com.bun.miitmdid.interfaces.IdSupplier
    public boolean isSupported() {
        return ((Boolean) Utils.rL(new Object[]{this, 59, 1594371206335L})).booleanValue();
    }
}
