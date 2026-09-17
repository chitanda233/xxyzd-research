package com.gorilla.appdownload;

/* JADX INFO: loaded from: classes3.dex */
public interface IDownloadResult {
    public static final int CODE_DOWNLOAD_COMPLETE = 0;
    public static final int CODE_FAILED = -1;
    public static final int CODE_INSTALL_STARTED = 1;

    void OnResult(int i, String str);
}
