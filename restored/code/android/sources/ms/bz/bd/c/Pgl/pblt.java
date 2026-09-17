package ms.bz.bd.c.Pgl;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;

/* JADX INFO: loaded from: classes4.dex */
public final class pblt {
    pblu c;
    ServiceConnection tt = new pgla();
    private final Context ve;

    final class pgla implements ServiceConnection {
        pgla() {
        }

        @Override // android.content.ServiceConnection
        public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            pblt.this.c = new pblu(iBinder);
        }

        @Override // android.content.ServiceConnection
        public final void onServiceDisconnected(ComponentName componentName) {
        }
    }

    public pblt(Context context) {
        this.ve = context;
    }

    public final void c(pblk.pblb pblbVar) {
        Intent intent = new Intent();
        intent.setClassName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "b8e8d0", new byte[]{112, com.sigmob.sdk.archives.tar.e.M, 27, 2, 65, com.sigmob.sdk.archives.tar.e.J, 104, 87, com.sigmob.sdk.archives.tar.e.H, 109, 101, com.sigmob.sdk.archives.tar.e.K, 21, 73, 82, 35, 114, 28, 38, 126, 122, 57, 19}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "f452cd", new byte[]{116, 57, 75, 8, 70, 102, 108, 91, 96, com.sigmob.sdk.archives.tar.e.T, 97, 63, 69, 67, 85, 119, 118, 16, 118, 116, 126, com.sigmob.sdk.archives.tar.e.M, 67, 8, com.sigmob.sdk.archives.tar.e.R, 118, 115, 28, com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.T, 126, com.sigmob.sdk.archives.tar.e.J, 117, 67, 78, 101, 108, 22, 97}));
        if (this.ve.bindService(intent, this.tt, 1)) {
            try {
                pblu pbluVar = this.c;
                if (pbluVar != null) {
                    String strC = pbluVar.c();
                    if (pblbVar != null) {
                        pblbVar.c(strC);
                    }
                }
            } catch (Throwable unused) {
            }
            this.ve.unbindService(this.tt);
        }
    }
}
