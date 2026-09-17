package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.message.MessageSnapshot;

/* JADX INFO: loaded from: classes3.dex */
public interface x extends s.a {

    public interface a {
        t Br();

        boolean a(MessageSnapshot messageSnapshot);

        boolean b(MessageSnapshot messageSnapshot);

        boolean c(MessageSnapshot messageSnapshot);

        boolean d(MessageSnapshot messageSnapshot);

        MessageSnapshot n(Throwable th);
    }

    public interface b {
        void start();
    }

    byte AT();

    Throwable AV();

    int AX();

    boolean AZ();

    void Bs();

    long Bt();

    void free();

    long getStatusUpdateTime();

    long getTotalBytes();

    boolean pause();

    void reset();
}
