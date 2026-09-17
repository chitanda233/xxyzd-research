package com.byazt.su;

import com.byazt.e.DownloadShortInfo;

/* JADX INFO: loaded from: classes2.dex */
public interface DownloadStatusChangeListener {
    void onDownloadActive(DownloadShortInfo downloadShortInfo, int i);

    void onDownloadFailed(DownloadShortInfo downloadShortInfo);

    void onDownloadFinished(DownloadShortInfo downloadShortInfo);

    void onDownloadPaused(DownloadShortInfo downloadShortInfo, int i);

    void onDownloadStart(DownloadModel downloadModel, DownloadController downloadController);

    void onIdle();

    void onInstalled(DownloadShortInfo downloadShortInfo);
}
