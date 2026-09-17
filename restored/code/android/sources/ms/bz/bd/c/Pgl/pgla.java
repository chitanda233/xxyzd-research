package ms.bz.bd.c.Pgl;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.LinkedBlockingQueue;
import kotlin.io.encoding.Base64;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes4.dex */
public final class pgla {
    public final LinkedBlockingQueue<IBinder> c = new LinkedBlockingQueue<>(1024);
    ServiceConnection tt = new ServiceConnectionC0578pgla();
    private final Context ve;

    /* JADX INFO: renamed from: ms.bz.bd.c.Pgl.pgla$pgla, reason: collision with other inner class name */
    final class ServiceConnectionC0578pgla implements ServiceConnection {
        ServiceConnectionC0578pgla() {
        }

        @Override // android.content.ServiceConnection
        public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                pgla.this.c.put(iBinder);
            } catch (Exception unused) {
            }
        }

        @Override // android.content.ServiceConnection
        public final void onServiceDisconnected(ComponentName componentName) {
        }
    }

    public pgla(Context context) {
        this.ve = context;
    }

    public final void c(pblk.pblb pblbVar) {
        try {
            this.ve.getPackageManager().getPackageInfo((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "e5f052", new byte[]{119, 56, 24, 10, 11, com.sigmob.sdk.archives.tar.e.N, 115, 7, 121, 109, com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.N, 91, 119, 31, com.sigmob.sdk.archives.tar.e.M, 118, 24, com.sigmob.sdk.archives.tar.e.J, 109, 113, 57, 1, 69, 24, 60, 66, Base64.padSymbol, 19}), 0);
        } catch (Exception unused) {
        }
        Intent intent = new Intent();
        intent.setAction((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "366278", new byte[]{33, 59, 72, 8, 9, 60, 37, 4, 41, 111, com.sigmob.sdk.archives.tar.e.I, com.sigmob.sdk.archives.tar.e.M, 11, 71, 11, 59, 57, 24, 105, 44, 3, 23, 102, 99, 59, 28, 15, com.sigmob.sdk.archives.tar.e.K, 78, 70}));
        intent.setComponent(new ComponentName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "b5cfb4", new byte[]{112, 56, 29, 92, 92, com.sigmob.sdk.archives.tar.e.H, 116, 7, 124, 59, 96, com.sigmob.sdk.archives.tar.e.N, 94, 33, 72, com.sigmob.sdk.archives.tar.e.K, 113, 24, com.sigmob.sdk.archives.tar.e.O, 59, 118, 57, 4, 19, 79, 58, 69, Base64.padSymbol, 22}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "72fab2", new byte[]{37, 63, 24, 91, 92, com.sigmob.sdk.archives.tar.e.N, 33, 0, 121, 60, com.sigmob.sdk.archives.tar.e.M, com.sigmob.sdk.archives.tar.e.I, 91, 38, 72, com.sigmob.sdk.archives.tar.e.M, 36, 31, com.sigmob.sdk.archives.tar.e.J, 60, 35, 62, 1, 20, 79, 60, 16, 58, 19, ByteCompanionObject.MAX_VALUE, 21, 37, 5, 5, 81, 32, 57, 22, 57, 37, 39, 34, 12, com.sigmob.sdk.archives.tar.e.I, 116, 1, 7, 22, 37, 39, 47, com.sigmob.sdk.archives.tar.e.K, 16})));
        if (this.ve.bindService(intent, this.tt, 1)) {
            try {
                String strC = new pblb(this.c.take()).c();
                if (pblbVar != null) {
                    pblbVar.c(strC);
                }
            } catch (Exception unused2) {
            } finally {
                this.ve.unbindService(this.tt);
            }
        }
    }
}
