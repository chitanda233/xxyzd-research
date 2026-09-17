package com.tencent.turingfd.sdk.ams.ad;

import android.os.Binder;
import android.os.Bundle;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Cascara extends Binder implements IInterface {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AtomicReference f3833a;
    public final boolean b;

    public Cascara(boolean z) {
        attachInterface(this, "com.hihonor.cloudservice.oaid.IOAIDCallBack");
        this.f3833a = new AtomicReference(null);
        this.b = z;
    }

    @Override // android.os.IInterface
    public final IBinder asBinder() {
        return this;
    }

    @Override // android.os.Binder
    public final boolean onTransact(int i, Parcel parcel, Parcel parcel2, int i2) {
        try {
            if (i == 1) {
                parcel.enforceInterface("com.hihonor.cloudservice.oaid.IOAIDCallBack");
                parcel2.writeNoException();
                return true;
            }
            if (i != 2) {
                if (i != 1598968902) {
                    return super.onTransact(i, parcel, parcel2, i2);
                }
                parcel2.writeString("com.hihonor.cloudservice.oaid.IOAIDCallBack");
                return true;
            }
            parcel.enforceInterface("com.hihonor.cloudservice.oaid.IOAIDCallBack");
            int i3 = parcel.readInt();
            Bundle bundle = parcel.readInt() != 0 ? (Bundle) Bundle.CREATOR.createFromParcel(parcel) : null;
            if (!this.b) {
                String string = "";
                if (i3 == 0 && bundle != null) {
                    string = bundle.getString("oa_id_flag");
                }
                synchronized (this.f3833a) {
                    this.f3833a.set(string);
                    this.f3833a.notifyAll();
                }
            }
            parcel2.writeNoException();
            return true;
        } catch (RemoteException unused) {
            return false;
        }
    }

    public final String toString() {
        synchronized (this.f3833a) {
            String str = (String) this.f3833a.get();
            if (str != null) {
                return str;
            }
            try {
                this.f3833a.wait(2000L);
            } catch (InterruptedException unused) {
            }
            return (String) this.f3833a.get();
        }
    }
}
