package com.czhj.devicehelper.cnoaid.impl;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.RemoteException;
import com.bun.miitmdid.content.StringValues;
import com.czhj.devicehelper.cnoaid.com.bun.lib.MsaIdInterface;

/* JADX INFO: loaded from: classes2.dex */
class k implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2202a;

    public k(Context context) {
        this.f2202a = context;
    }

    private void b() {
        try {
            Intent intent = new Intent(StringValues.ACTION_START_MSASERVICE);
            intent.setClassName("com.mdid.msa", "com.mdid.msa.service.MsaKlService");
            intent.putExtra(StringValues.PARAM_BIND_PKGNAME, this.f2202a.getPackageName());
            this.f2202a.startForegroundService(intent);
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
        }
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2202a == null || cVar == null) {
            return;
        }
        b();
        Intent intent = new Intent(StringValues.ACTION_BINDTO_MSASERVICE);
        intent.setClassName("com.mdid.msa", "com.mdid.msa.service.MsaIdService");
        intent.putExtra(StringValues.PARAM_BIND_PKGNAME, this.f2202a.getPackageName());
        n.a(this.f2202a, intent, cVar, new n.a() { // from class: com.czhj.devicehelper.cnoaid.impl.k.1
            @Override // com.czhj.devicehelper.cnoaid.impl.n.a
            public String a(IBinder iBinder) throws com.czhj.devicehelper.cnoaid.f, RemoteException {
                MsaIdInterface msaIdInterfaceAsInterface = MsaIdInterface.Stub.asInterface(iBinder);
                if (msaIdInterfaceAsInterface == null) {
                    throw new com.czhj.devicehelper.cnoaid.f("MsaIdInterface is null");
                }
                if (msaIdInterfaceAsInterface.isSupported()) {
                    return msaIdInterfaceAsInterface.getOAID();
                }
                throw new com.czhj.devicehelper.cnoaid.f("MsaIdInterface#isSupported return false");
            }
        });
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public boolean a() {
        Context context = this.f2202a;
        if (context == null) {
            return false;
        }
        try {
            return context.getPackageManager().getPackageInfo("com.mdid.msa", 0) != null;
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            return false;
        }
    }
}
