package com.kwad.framework.filedownloader;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.RemoteException;
import com.kwad.framework.filedownloader.message.MessageSnapshot;

/* JADX INFO: loaded from: classes3.dex */
final class p extends com.kwad.framework.filedownloader.services.a<a, com.kwad.framework.filedownloader.c.b> {
    @Override // com.kwad.framework.filedownloader.services.a
    public final /* synthetic */ Binder BP() {
        return BO();
    }

    @Override // com.kwad.framework.filedownloader.services.a
    public final /* bridge */ /* synthetic */ void a(IInterface iInterface, Binder binder) {
        a((com.kwad.framework.filedownloader.c.b) iInterface, (a) binder);
    }

    @Override // com.kwad.framework.filedownloader.services.a
    public final /* synthetic */ IInterface b(IBinder iBinder) {
        return a(iBinder);
    }

    p(Class<?> cls) {
        super(cls);
    }

    private static a BO() {
        return new a();
    }

    private static com.kwad.framework.filedownloader.c.b a(IBinder iBinder) {
        return com.kwad.framework.filedownloader.c.b.a.a(iBinder);
    }

    private static void a(com.kwad.framework.filedownloader.c.b bVar, a aVar) {
        bVar.a(aVar);
    }

    protected static class a extends com.kwad.framework.filedownloader.c.a.AbstractBinderC0484a {
        protected a() {
        }

        @Override // com.kwad.framework.filedownloader.c.a
        public final void q(MessageSnapshot messageSnapshot) {
            com.kwad.framework.filedownloader.message.e.Dd().s(messageSnapshot);
        }
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean a(String str, String str2, boolean z, int i, int i2, int i3, boolean z2, com.kwad.framework.filedownloader.d.b bVar, boolean z3) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.h(str, str2, z);
        }
        try {
            Do().b(str, str2, z, i, i2, i3, z2, bVar, z3);
            return true;
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cl(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cl(i);
        }
        try {
            return Do().cl(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }

    @Override // com.kwad.framework.filedownloader.u
    public final byte cm(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cm(i);
        }
        try {
            return Do().cm(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return (byte) 0;
        }
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cn(int i) {
        if (!isConnected()) {
            return com.kwad.framework.filedownloader.f.a.cn(i);
        }
        try {
            return Do().cn(i);
        } catch (RemoteException e) {
            e.printStackTrace();
            return false;
        }
    }
}
