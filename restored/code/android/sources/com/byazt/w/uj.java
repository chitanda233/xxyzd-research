package com.byazt.w;

import androidx.core.view.PointerIconCompat;
import com.byazt.t.DownloadInfo;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_TOP_LEFT_DIAGONAL_DOUBLE_ARROW, 15})
public class uj {
    public static boolean c(DownloadInfo downloadInfo) {
        return downloadInfo != null && com.byazt.k.c.c(downloadInfo.getId()).tt("optimize_head_request") == 1;
    }

    public static boolean tt(DownloadInfo downloadInfo) {
        return downloadInfo != null && com.byazt.k.c.c(downloadInfo.getId()).tt("optimize_save_path") == 1;
    }
}
