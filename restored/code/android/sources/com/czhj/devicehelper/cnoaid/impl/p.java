package com.czhj.devicehelper.cnoaid.impl;

import android.app.Application;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.IBinder;
import android.os.RemoteException;
import com.czhj.devicehelper.cnoaid.com.heytap.openid.IOpenID;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
class p implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2209a;
    private String b;

    public p(Context context) {
        this.f2209a = context instanceof Application ? context : context.getApplicationContext();
    }

    protected String a(IBinder iBinder) throws PackageManager.NameNotFoundException, NoSuchAlgorithmException, com.czhj.devicehelper.cnoaid.f, RemoteException {
        String packageName = this.f2209a.getPackageName();
        String str = this.b;
        if (str != null) {
            return a(iBinder, packageName, str);
        }
        byte[] bArrDigest = MessageDigest.getInstance("SHA1").digest(this.f2209a.getPackageManager().getPackageInfo(packageName, 64).signatures[0].toByteArray());
        StringBuilder sb = new StringBuilder();
        for (byte b : bArrDigest) {
            sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
        }
        String string = sb.toString();
        this.b = string;
        return a(iBinder, packageName, string);
    }

    protected String a(IBinder iBinder, String str, String str2) throws com.czhj.devicehelper.cnoaid.f, RemoteException {
        IOpenID iOpenIDAsInterface = IOpenID.Stub.asInterface(iBinder);
        if (iOpenIDAsInterface != null) {
            return iOpenIDAsInterface.getSerID(str, str2, "OUID");
        }
        throw new com.czhj.devicehelper.cnoaid.f("IOpenID is null");
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2209a == null || cVar == null) {
            return;
        }
        Intent intent = new Intent("action.com.heytap.openid.OPEN_ID_SERVICE");
        intent.setComponent(new ComponentName("com.heytap.openid", "com.heytap.openid.IdentifyService"));
        n.a(this.f2209a, intent, cVar, new n.a() { // from class: com.czhj.devicehelper.cnoaid.impl.p.1
            @Override // com.czhj.devicehelper.cnoaid.impl.n.a
            public String a(IBinder iBinder) throws com.czhj.devicehelper.cnoaid.f, RemoteException {
                try {
                    return p.this.a(iBinder);
                } catch (RemoteException e) {
                    throw e;
                } catch (com.czhj.devicehelper.cnoaid.f e2) {
                    throw e2;
                } catch (Exception e3) {
                    throw new com.czhj.devicehelper.cnoaid.f(e3);
                }
            }
        });
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public boolean a() {
        Context context = this.f2209a;
        if (context == null) {
            return false;
        }
        try {
            return context.getPackageManager().getPackageInfo("com.heytap.openid", 0) != null;
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            return false;
        }
    }
}
