package com.byazt.mk;

import java.io.Closeable;
import java.io.Flushable;
import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
public interface rh extends Closeable, Flushable {
    void a_(ve veVar, long j) throws IOException;

    gt c();

    @Override // java.io.Closeable, java.lang.AutoCloseable
    void close() throws IOException;

    void flush() throws IOException;
}
