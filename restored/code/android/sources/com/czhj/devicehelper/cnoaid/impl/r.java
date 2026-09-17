package com.czhj.devicehelper.cnoaid.impl;

import android.content.Context;
import android.content.Intent;
import android.os.IBinder;
import android.os.RemoteException;
import com.czhj.devicehelper.cnoaid.com.samsung.android.deviceidservice.IDeviceIdService;

/* JADX INFO: loaded from: classes2.dex */
class r implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2213a;

    public r(Context context) {
        this.f2213a = context;
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2213a == null || cVar == null) {
            return;
        }
        Intent intent = new Intent();
        intent.setClassName("com.samsung.android.deviceidservice", "com.samsung.android.deviceidservice.DeviceIdService");
        n.a(this.f2213a, intent, cVar, new n.a() { // from class: com.czhj.devicehelper.cnoaid.impl.r.1
            @Override // com.czhj.devicehelper.cnoaid.impl.n.a
            public String a(IBinder iBinder) throws com.czhj.devicehelper.cnoaid.f, RemoteException {
                IDeviceIdService iDeviceIdServiceAsInterface = IDeviceIdService.Stub.asInterface(iBinder);
                if (iDeviceIdServiceAsInterface != null) {
                    return iDeviceIdServiceAsInterface.getOAID();
                }
                throw new com.czhj.devicehelper.cnoaid.f("IDeviceIdService is null");
            }
        });
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public boolean a() {
        Context context = this.f2213a;
        if (context == null) {
            return false;
        }
        try {
            return context.getPackageManager().getPackageInfo("com.samsung.android.deviceidservice", 0) != null;
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            return false;
        }
    }
}
