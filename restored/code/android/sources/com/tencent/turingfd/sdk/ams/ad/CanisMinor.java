package com.tencent.turingfd.sdk.ams.ad;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.channels.FileChannel;
import java.nio.channels.FileLock;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public abstract class CanisMinor {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final HashMap f3832a = new HashMap();

    public static boolean a(String str, byte[] bArr) {
        Canesatici canesatici;
        RandomAccessFile randomAccessFile;
        FileChannel channel;
        HashMap map = f3832a;
        synchronized (map) {
            canesatici = (Canesatici) map.get(str);
            if (canesatici == null) {
                canesatici = new Canesatici();
                map.put(str, canesatici);
            }
            canesatici.b.incrementAndGet();
        }
        canesatici.f3831a.writeLock().lock();
        FileLock fileLockLock = null;
        try {
            randomAccessFile = new RandomAccessFile(str, "rw");
            try {
                channel = randomAccessFile.getChannel();
                try {
                    fileLockLock = channel.lock();
                    randomAccessFile.seek(0L);
                    randomAccessFile.write(bArr);
                    randomAccessFile.setLength(bArr.length);
                    if (fileLockLock != null && fileLockLock.isValid()) {
                        try {
                            fileLockLock.release();
                        } catch (IOException unused) {
                        }
                    }
                    GalacticCore.a(channel);
                    GalacticCore.a(randomAccessFile);
                    HashMap map2 = f3832a;
                    synchronized (map2) {
                        canesatici.f3831a.writeLock().unlock();
                        if (canesatici.b.decrementAndGet() == 0) {
                            map2.remove(str);
                        }
                    }
                    return true;
                } catch (Throwable unused2) {
                    if (fileLockLock != null && fileLockLock.isValid()) {
                        try {
                            fileLockLock.release();
                        } catch (IOException unused3) {
                        }
                    }
                    GalacticCore.a(channel);
                    GalacticCore.a(randomAccessFile);
                    HashMap map3 = f3832a;
                    synchronized (map3) {
                        canesatici.f3831a.writeLock().unlock();
                        if (canesatici.b.decrementAndGet() == 0) {
                            map3.remove(str);
                        }
                    }
                    return false;
                }
            } catch (Throwable unused4) {
                channel = null;
            }
        } catch (Throwable unused5) {
            randomAccessFile = null;
            channel = null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:45:0x00ab A[Catch: all -> 0x00b0, TryCatch #0 {, blocks: (B:43:0x009a, B:45:0x00ab, B:46:0x00ae), top: B:57:0x009a }] */
    /* JADX WARN: Code duplicated, block: B:57:0x009a A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public static byte[] b(String str) {
        Canesatici canesatici;
        RandomAccessFile randomAccessFile;
        FileChannel channel;
        FileLock fileLockLock;
        HashMap map;
        HashMap map2 = f3832a;
        synchronized (map2) {
            canesatici = (Canesatici) map2.get(str);
            if (canesatici == null) {
                canesatici = new Canesatici();
                map2.put(str, canesatici);
            }
            canesatici.b.incrementAndGet();
        }
        canesatici.f3831a.readLock().lock();
        try {
            randomAccessFile = new RandomAccessFile(str, com.kuaishou.weapon.p0.t.k);
            try {
                channel = randomAccessFile.getChannel();
                try {
                    fileLockLock = channel.lock(0L, Long.MAX_VALUE, true);
                    try {
                        long length = randomAccessFile.length();
                        int i = (int) length;
                        if (i != length) {
                            throw new IOException("");
                        }
                        byte[] bArr = new byte[i];
                        randomAccessFile.readFully(bArr);
                        if (fileLockLock != null && fileLockLock.isValid()) {
                            try {
                                fileLockLock.release();
                            } catch (IOException unused) {
                            }
                        }
                        GalacticCore.a(channel);
                        GalacticCore.a(randomAccessFile);
                        HashMap map3 = f3832a;
                        synchronized (map3) {
                            canesatici.f3831a.readLock().unlock();
                            if (canesatici.b.decrementAndGet() == 0) {
                                map3.remove(str);
                            }
                        }
                        return bArr;
                    } catch (Throwable unused2) {
                        if (fileLockLock != null) {
                            try {
                                fileLockLock.release();
                            } catch (IOException unused3) {
                            }
                        }
                        GalacticCore.a(channel);
                        GalacticCore.a(randomAccessFile);
                        map = f3832a;
                        synchronized (map) {
                            canesatici.f3831a.readLock().unlock();
                            if (canesatici.b.decrementAndGet() == 0) {
                                map.remove(str);
                            }
                            return null;
                        }
                    }
                } catch (Throwable unused4) {
                    fileLockLock = null;
                }
            } catch (Throwable unused5) {
                channel = null;
                fileLockLock = channel;
                if (fileLockLock != null && fileLockLock.isValid()) {
                    fileLockLock.release();
                }
                GalacticCore.a(channel);
                GalacticCore.a(randomAccessFile);
                map = f3832a;
                synchronized (map) {
                    canesatici.f3831a.readLock().unlock();
                    if (canesatici.b.decrementAndGet() == 0) {
                        map.remove(str);
                    }
                }
                return null;
            }
        } catch (Throwable unused6) {
            randomAccessFile = null;
            channel = null;
        }
    }

    public static byte[] a(String str, int i) {
        FileInputStream fileInputStream;
        File file = new File(str);
        if (!file.exists()) {
            return null;
        }
        try {
            fileInputStream = new FileInputStream(file);
            try {
                byte[] bArr = new byte[i];
                int i2 = 0;
                do {
                    int i3 = fileInputStream.read(bArr, i2, i - i2);
                    if (i3 == -1) {
                        break;
                    }
                    i2 += i3;
                } while (i2 < i);
                if (i2 == 0) {
                    GalacticCore.a(fileInputStream);
                    return null;
                }
                if (i2 < i) {
                    byte[] bArr2 = new byte[i2];
                    System.arraycopy(bArr, 0, bArr2, 0, i2);
                    bArr = bArr2;
                }
                GalacticCore.a(fileInputStream);
                return bArr;
            } catch (Throwable unused) {
                GalacticCore.a(fileInputStream);
                return null;
            }
        } catch (Throwable unused2) {
            fileInputStream = null;
        }
    }

    public static byte[] a(String str) {
        FileInputStream fileInputStream;
        Throwable th;
        ByteArrayOutputStream byteArrayOutputStream;
        try {
            fileInputStream = new FileInputStream(str);
            try {
                byteArrayOutputStream = new ByteArrayOutputStream(fileInputStream.available());
                try {
                    byte[] bArr = new byte[4096];
                    while (true) {
                        int i = fileInputStream.read(bArr);
                        if (-1 == i) {
                            break;
                        }
                        byteArrayOutputStream.write(bArr, 0, i);
                    }
                    byte[] byteArray = byteArrayOutputStream.toByteArray();
                    if (byteArray == null) {
                        byteArray = "".getBytes();
                    }
                    GalacticCore.a(fileInputStream);
                    GalacticCore.a(byteArrayOutputStream);
                    return byteArray;
                } catch (Throwable th2) {
                    th = th2;
                    try {
                        throw th;
                    } catch (Throwable th3) {
                        GalacticCore.a(fileInputStream);
                        GalacticCore.a(byteArrayOutputStream);
                        throw th3;
                    }
                }
            } catch (Throwable th4) {
                th = th4;
                byteArrayOutputStream = null;
            }
        } catch (Throwable th5) {
            fileInputStream = null;
            th = th5;
            byteArrayOutputStream = null;
        }
    }

    public static void a(File file) {
        if (file.exists()) {
            if (!file.isDirectory()) {
                try {
                    file.delete();
                    return;
                } catch (Throwable unused) {
                    return;
                }
            }
            File[] fileArrListFiles = file.listFiles();
            if (fileArrListFiles != null) {
                for (File file2 : fileArrListFiles) {
                    a(file2);
                }
            }
            try {
                file.delete();
            } catch (Throwable unused2) {
            }
        }
    }
}
