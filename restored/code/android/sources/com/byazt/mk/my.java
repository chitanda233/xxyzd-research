package com.byazt.mk;

import java.io.Closeable;
import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
public interface my extends Closeable {
    long c(ve veVar, long j) throws IOException;

    gt c();

    @Override // java.io.Closeable, java.lang.AutoCloseable
    void close() throws IOException;
}
