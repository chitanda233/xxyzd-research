package com.kwad.sdk;

import android.content.Context;
import com.kwad.framework.filedownloader.r;
import com.kwad.sdk.utils.an;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bg;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.util.Iterator;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private com.kwad.sdk.a aFH;
    private d aFJ;
    private Context mContext;
    private final Map<Integer, DownloadTask> Bt = new ConcurrentHashMap();
    private final Map<String, Integer> aFG = new ConcurrentHashMap();
    private boolean aFI = false;

    public static c EK() {
        return a.aFM;
    }

    public final void init(Context context) {
        this.mContext = context;
        r.a(context, new com.kwad.framework.filedownloader.services.c.b().cP(Integer.MAX_VALUE).a(new com.kwad.framework.filedownloader.services.c.a() { // from class: com.kwad.sdk.c.1
            @Override // com.kwad.framework.filedownloader.services.c.a
            public final com.kwad.framework.filedownloader.f.c.b Cs() {
                try {
                    l.a aVar = new l.a(false);
                    aVar.bV("");
                    return aVar;
                } catch (Throwable unused) {
                    return null;
                }
            }
        }));
    }

    public final Context getContext() {
        return this.mContext;
    }

    public final File EL() {
        return bg.ee(this.mContext);
    }

    public final d EM() {
        if (this.aFJ == null) {
            this.aFJ = new com.kwad.sdk.core.download.b.a();
        }
        return this.aFJ;
    }

    public final void g(DownloadTask downloadTask) {
        final String strMd5 = an.md5(downloadTask.getUrl());
        au.a(downloadTask.getTargetFilePath(), new au.a() { // from class: com.kwad.sdk.c.2
            @Override // com.kwad.sdk.utils.au.a
            public final void qC() {
                com.kwad.sdk.core.download.b.LK().eB(strMd5);
            }

            @Override // com.kwad.sdk.utils.au.a
            public final void d(Throwable th) {
                com.kwad.sdk.core.download.b.LK().g(strMd5, th);
            }
        });
    }

    public static boolean EN() {
        try {
            Class.forName("com.kwad.sdk.api.proxy.app.BaseFragmentActivity.RequestInstallPermissionActivity");
            return true;
        } catch (Throwable unused) {
            return false;
        }
    }

    private void EO() {
        l.a aVar;
        try {
            aVar = new l.a(true);
        } catch (Throwable th) {
            th.printStackTrace();
            aVar = null;
        }
        if (aVar != null) {
            com.kwad.framework.filedownloader.download.b.Cm().b(new com.kwad.framework.filedownloader.services.c.b().cP(Integer.MAX_VALUE).a(aVar));
            this.aFI = true;
        }
    }

    private static void EP() {
        l.a aVar;
        try {
            aVar = new l.a(false);
        } catch (Throwable th) {
            th.printStackTrace();
            aVar = null;
        }
        if (aVar != null) {
            com.kwad.framework.filedownloader.download.b.Cm().b(new com.kwad.framework.filedownloader.services.c.b().cP(Integer.MAX_VALUE).a(aVar));
        }
    }

    public final int a(DownloadTask.DownloadRequest downloadRequest, com.kwad.sdk.a aVar) {
        DownloadTask downloadTask = new DownloadTask(downloadRequest);
        if (downloadRequest.getDownloadUrl().contains("downali.game.uc.cn")) {
            EO();
        } else if (this.aFI) {
            EP();
        }
        if (this.Bt.get(Integer.valueOf(downloadTask.getId())) != null) {
            a(downloadTask.getId(), downloadRequest);
            db(downloadTask.getId());
        } else {
            this.Bt.put(Integer.valueOf(downloadTask.getId()), downloadTask);
            this.aFG.put(downloadTask.getUrl(), Integer.valueOf(downloadTask.getId()));
            downloadTask.submit();
        }
        a(downloadTask.getId(), null, this.aFH);
        return downloadTask.getId();
    }

    public final DownloadTask da(int i) {
        return this.Bt.get(Integer.valueOf(i));
    }

    private void db(int i) {
        DownloadTask downloadTask = this.Bt.get(Integer.valueOf(i));
        if (downloadTask != null) {
            downloadTask.clearListener();
        }
    }

    public final boolean EQ() {
        Iterator<Map.Entry<Integer, DownloadTask>> it = this.Bt.entrySet().iterator();
        while (true) {
            boolean z = false;
            while (it.hasNext()) {
                DownloadTask value = it.next().getValue();
                if (value != null) {
                    int status = value.getStatus();
                    if (status != -2 && status != 1 && status != 2 && status != 3 && status != 5 && status != 6 && status != 10 && status != 11 && Math.abs(value.getStatusUpdateTime() - System.currentTimeMillis()) > 120000) {
                        z = true;
                    }
                }
            }
            return z;
        }
    }

    private void a(int i, com.kwad.sdk.a... aVarArr) {
        DownloadTask downloadTask = this.Bt.get(Integer.valueOf(i));
        if (downloadTask != null) {
            for (int i2 = 0; i2 < 2; i2++) {
                com.kwad.sdk.a aVar = aVarArr[i2];
                if (aVar != null) {
                    aVar.setId(i);
                    downloadTask.addListener(aVar);
                }
            }
        }
    }

    public final void a(com.kwad.sdk.a aVar) {
        this.aFH = aVar;
    }

    public final void cancel(int i) {
        DownloadTask downloadTask = this.Bt.get(Integer.valueOf(i));
        if (downloadTask != null) {
            downloadTask.cancel();
            h(downloadTask);
        }
    }

    public static void cJ(String str) {
        if (str == null) {
            return;
        }
        y.delete(com.kwad.framework.filedownloader.f.f.ck(str));
        y.delete(str);
    }

    private void h(DownloadTask downloadTask) {
        this.Bt.remove(Integer.valueOf(downloadTask.getId()));
        this.aFG.remove(downloadTask.getUrl());
    }

    public final void pause(int i) {
        DownloadTask downloadTask = this.Bt.get(Integer.valueOf(i));
        if (downloadTask != null) {
            downloadTask.userPause();
        }
    }

    public final void resume(int i) {
        a(i, (DownloadTask.DownloadRequest) null);
    }

    public final void dc(int i) {
        DownloadTask downloadTaskDa = da(i);
        if (downloadTaskDa == null) {
            return;
        }
        if (downloadTaskDa.isUserPause()) {
            downloadTaskDa.downloadType = 2;
            resume(i);
        } else {
            pause(i);
        }
    }

    private void a(int i, DownloadTask.DownloadRequest downloadRequest) {
        DownloadTask downloadTask = this.Bt.get(Integer.valueOf(i));
        if (downloadTask != null) {
            downloadTask.resume(downloadRequest);
        }
    }

    static final class a {
        private static final c aFM = new c();
    }
}
