package com.kwad.framework.filedownloader.services;

import android.util.SparseArray;
import com.kwad.framework.filedownloader.download.DownloadLaunchRunnable;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ThreadPoolExecutor;

/* JADX INFO: loaded from: classes3.dex */
final class h {
    private ThreadPoolExecutor aDk;
    private int aDm;
    private SparseArray<DownloadLaunchRunnable> aDj = new SparseArray<>();
    private final String aDl = "Network";
    private int aDn = 0;

    h(int i) {
        this.aDk = com.kwad.framework.filedownloader.f.b.v(i, "Network");
        this.aDm = i;
    }

    public final synchronized boolean cF(int i) {
        if (DE() > 0) {
            com.kwad.framework.filedownloader.f.d.d(this, "Can't change the max network thread count, because the  network thread pool isn't in IDLE, please try again after all running tasks are completed or invoking FileDownloader#pauseAll directly.", new Object[0]);
            return false;
        }
        int iCT = com.kwad.framework.filedownloader.f.e.cT(i);
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "change the max network thread count, from %d to %d", Integer.valueOf(this.aDm), Integer.valueOf(iCT));
        }
        List<Runnable> listShutdownNow = this.aDk.shutdownNow();
        this.aDk = com.kwad.framework.filedownloader.f.b.v(iCT, "Network");
        if (listShutdownNow.size() > 0) {
            com.kwad.framework.filedownloader.f.d.d(this, "recreate the network thread pool and discard %d tasks", Integer.valueOf(listShutdownNow.size()));
        }
        this.aDm = iCT;
        return true;
    }

    public final void a(DownloadLaunchRunnable downloadLaunchRunnable) {
        downloadLaunchRunnable.Cw();
        synchronized (this) {
            this.aDj.put(downloadLaunchRunnable.getId(), downloadLaunchRunnable);
        }
        this.aDk.execute(downloadLaunchRunnable);
        int i = this.aDn;
        if (i >= 600) {
            DD();
            this.aDn = 0;
        } else {
            this.aDn = i + 1;
        }
    }

    public final void cancel(int i) {
        DD();
        synchronized (this) {
            DownloadLaunchRunnable downloadLaunchRunnable = this.aDj.get(i);
            if (downloadLaunchRunnable != null) {
                downloadLaunchRunnable.pause();
                boolean zRemove = this.aDk.remove(downloadLaunchRunnable);
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "successful cancel %d %B", Integer.valueOf(i), Boolean.valueOf(zRemove));
                }
            }
            this.aDj.remove(i);
        }
    }

    private synchronized void DD() {
        SparseArray<DownloadLaunchRunnable> sparseArray = new SparseArray<>();
        int size = this.aDj.size();
        for (int i = 0; i < size; i++) {
            int iKeyAt = this.aDj.keyAt(i);
            DownloadLaunchRunnable downloadLaunchRunnable = this.aDj.get(iKeyAt);
            if (downloadLaunchRunnable.isAlive()) {
                sparseArray.put(iKeyAt, downloadLaunchRunnable);
            }
        }
        this.aDj = sparseArray;
    }

    public final boolean cS(int i) {
        DownloadLaunchRunnable downloadLaunchRunnable = this.aDj.get(i);
        return downloadLaunchRunnable != null && downloadLaunchRunnable.isAlive();
    }

    public final int p(String str, int i) {
        if (str == null) {
            return 0;
        }
        int size = this.aDj.size();
        for (int i2 = 0; i2 < size; i2++) {
            DownloadLaunchRunnable downloadLaunchRunnableValueAt = this.aDj.valueAt(i2);
            if (downloadLaunchRunnableValueAt != null && downloadLaunchRunnableValueAt.isAlive() && downloadLaunchRunnableValueAt.getId() != i && str.equals(downloadLaunchRunnableValueAt.CB())) {
                return downloadLaunchRunnableValueAt.getId();
            }
        }
        return 0;
    }

    public final synchronized int DE() {
        DD();
        return this.aDj.size();
    }

    public final synchronized List<Integer> DF() {
        ArrayList arrayList;
        DD();
        arrayList = new ArrayList();
        for (int i = 0; i < this.aDj.size(); i++) {
            SparseArray<DownloadLaunchRunnable> sparseArray = this.aDj;
            arrayList.add(Integer.valueOf(sparseArray.get(sparseArray.keyAt(i)).getId()));
        }
        return arrayList;
    }
}
