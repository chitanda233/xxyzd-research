package com.tencent.turingfd.sdk.ams.ad;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.nio.channels.FileLock;
import java.util.HashMap;
import java.util.StringTokenizer;

/* JADX INFO: loaded from: classes4.dex */
public final class Quarenden implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Rambutan f3883a;

    public Quarenden(Rambutan rambutan) {
        this.f3883a = rambutan;
    }

    @Override // java.lang.Runnable
    public final void run() {
        FileChannel channel;
        RandomAccessFile randomAccessFile;
        FileLock fileLockLock;
        int iIndexOf;
        Rambutan rambutan;
        System.currentTimeMillis();
        String string = this.f3883a.toString();
        File fileA = Raspberry.a();
        int length = string.length();
        synchronized (Raspberry.b) {
            ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
            FileLock fileLock = null;
            try {
                randomAccessFile = new RandomAccessFile(fileA, "rw");
                try {
                    channel = randomAccessFile.getChannel();
                    try {
                        fileLockLock = channel.lock();
                        try {
                            if (randomAccessFile.length() != 0) {
                                ByteBuffer byteBufferAllocate = ByteBuffer.allocate(1024);
                                while (true) {
                                    int i = channel.read(byteBufferAllocate);
                                    if (i <= 0) {
                                        break;
                                    }
                                    byteArrayOutputStream.write(byteBufferAllocate.array(), 0, i);
                                    byteBufferAllocate.clear();
                                    fileLock = fileLockLock;
                                    if (fileLock != null && fileLock.isValid()) {
                                        try {
                                            fileLock.release();
                                        } catch (IOException unused) {
                                        }
                                    }
                                    GalacticCore.a(channel);
                                    GalacticCore.a(randomAccessFile);
                                }
                                string = byteArrayOutputStream + "," + string;
                                while (string.length() > (length + 1) * 50 && (iIndexOf = string.indexOf(",")) >= 0) {
                                    try {
                                        StringTokenizer stringTokenizer = new StringTokenizer(string.substring(0, iIndexOf), ":");
                                        try {
                                            rambutan = new Rambutan(Long.parseLong(stringTokenizer.nextToken()), stringTokenizer.nextToken());
                                        } catch (Throwable unused2) {
                                            rambutan = null;
                                        }
                                        if (rambutan != null) {
                                            String strValueOf = String.valueOf(Bullace.a(rambutan.b.getBytes()));
                                            HashMap map = Raspberry.f3885a;
                                            synchronized (map) {
                                                map.remove(strValueOf);
                                            }
                                        }
                                        string = string.substring(iIndexOf + 1);
                                    } catch (Throwable unused3) {
                                    }
                                }
                            }
                            channel.position(0L);
                            ByteBuffer byteBufferWrap = ByteBuffer.wrap(string.getBytes());
                            while (byteBufferWrap.hasRemaining()) {
                                channel.write(byteBufferWrap);
                            }
                            channel.truncate(byteBufferWrap.position());
                            if (fileLockLock != null && fileLockLock.isValid()) {
                                try {
                                    fileLockLock.release();
                                } catch (IOException unused4) {
                                }
                            }
                            GalacticCore.a(channel);
                        } catch (Throwable unused5) {
                            fileLock = channel;
                            channel = fileLock;
                        }
                    } catch (Throwable unused6) {
                        fileLockLock = null;
                    }
                } catch (Throwable unused7) {
                    fileLockLock = null;
                }
            } catch (Throwable unused8) {
                channel = null;
                randomAccessFile = null;
            }
            GalacticCore.a(randomAccessFile);
        }
    }
}
