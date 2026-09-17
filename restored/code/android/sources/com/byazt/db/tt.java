package com.byazt.db;

import java.util.List;

/* JADX INFO: loaded from: classes.dex */
public interface tt {
    void nativeDislikeClick(com.byazt.yl.ve veVar, String str);

    void notifyLoadFail(com.byazt.pp.c cVar);

    void notifyLoadSuccess(List<com.byazt.yl.ve> list);

    void notifyVideoCache(List<com.byazt.yl.ve> list, com.byazt.pp.c cVar);
}
