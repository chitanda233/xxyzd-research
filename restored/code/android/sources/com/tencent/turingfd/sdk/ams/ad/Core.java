package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageInfo;
import android.content.pm.Signature;
import android.text.TextUtils;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.nio.channels.FileLock;
import java.security.cert.CertificateFactory;
import java.security.cert.X509Certificate;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Core {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3841a = "mpdc_" + Olive.f3871a + "_1";
    public static final String b = "mpdc_r_" + Olive.f3871a + "_1";

    /* JADX WARN: Code duplicated, block: B:101:0x01ca A[Catch: all -> 0x0234, TRY_ENTER, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:103:0x01d3  */
    /* JADX WARN: Code duplicated, block: B:104:0x01d5 A[Catch: all -> 0x0234, TRY_LEAVE, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:113:0x0201 A[Catch: all -> 0x021c, LOOP:0: B:111:0x01fb->B:113:0x0201, LOOP_END, TryCatch #15 {all -> 0x021c, blocks: (B:110:0x01ec, B:111:0x01fb, B:113:0x0201, B:114:0x0205), top: B:174:0x01ec }] */
    /* JADX WARN: Code duplicated, block: B:116:0x020c A[Catch: all -> 0x0234, TRY_ENTER, TRY_LEAVE, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:125:0x0223 A[Catch: all -> 0x0234, TRY_LEAVE, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:178:0x01dd A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:185:0x0186 A[EDGE_INSN: B:185:0x0186->B:78:0x0186 BREAK  A[LOOP:1: B:75:0x0177->B:77:0x017d], SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:54:0x0123  */
    /* JADX WARN: Code duplicated, block: B:57:0x0127 A[Catch: all -> 0x0234, TRY_ENTER, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:59:0x013c  */
    /* JADX WARN: Code duplicated, block: B:60:0x013e A[Catch: all -> 0x0234, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:62:0x0145  */
    /* JADX WARN: Code duplicated, block: B:63:0x0148 A[Catch: all -> 0x0234, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:65:0x014e  */
    /* JADX WARN: Code duplicated, block: B:66:0x0151 A[Catch: all -> 0x0234, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:68:0x0157 A[Catch: all -> 0x0234, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:69:0x015d A[Catch: all -> 0x0234, TRY_LEAVE, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:77:0x017d A[Catch: all -> 0x01a5, LOOP:1: B:75:0x0177->B:77:0x017d, LOOP_END, TryCatch #7 {all -> 0x01a5, blocks: (B:74:0x0173, B:75:0x0177, B:77:0x017d, B:78:0x0186), top: B:159:0x0173 }] */
    /* JADX WARN: Code duplicated, block: B:93:0x01bc  */
    /* JADX WARN: Code duplicated, block: B:96:0x01c0 A[Catch: all -> 0x0234, TRY_ENTER, TryCatch #13 {all -> 0x0234, blocks: (B:4:0x0007, B:57:0x0127, B:96:0x01c0, B:101:0x01ca, B:116:0x020c, B:118:0x0212, B:119:0x0215, B:125:0x0223, B:127:0x0229, B:128:0x022c, B:104:0x01d5, B:63:0x0148, B:66:0x0151, B:68:0x0157, B:69:0x015d, B:80:0x018c, B:82:0x0192, B:83:0x0195, B:88:0x01a7, B:90:0x01ad, B:91:0x01b0, B:60:0x013e, B:7:0x0013, B:12:0x0021, B:14:0x0025, B:17:0x002f, B:23:0x0048, B:26:0x0050, B:28:0x0063, B:30:0x0066, B:39:0x0093, B:41:0x0098, B:42:0x009c, B:43:0x009d, B:51:0x00be, B:38:0x0090), top: B:171:0x0007, inners: #14 }] */
    /* JADX WARN: Code duplicated, block: B:98:0x01c6  */
    public static synchronized String a(Context context, String str) {
        ApplicationInfo applicationInfo;
        long length;
        String str2;
        ByteArrayInputStream byteArrayInputStream;
        String strA;
        File dir;
        File file;
        ByteArrayOutputStream byteArrayOutputStream;
        FileChannel channel;
        RandomAccessFile randomAccessFile;
        FileLock fileLockLock;
        ByteBuffer byteBufferAllocate;
        int i;
        String str3;
        File dir2;
        File file2;
        RandomAccessFile randomAccessFile2;
        FileChannel channel2;
        FileLock fileLock;
        FileLock fileLockLock2;
        ByteBuffer byteBufferAllocate2;
        try {
            String packageName = context.getPackageName();
            if (!TextUtils.isEmpty(packageName)) {
                try {
                    PackageInfo packageInfo = context.getPackageManager().getPackageInfo(packageName, 64);
                    if (packageInfo != null && (applicationInfo = packageInfo.applicationInfo) != null && !TextUtils.isEmpty(applicationInfo.sourceDir)) {
                        String str4 = applicationInfo.sourceDir;
                        File file3 = new File(str4);
                        int i2 = applicationInfo.flags;
                        long jLastModified = -1;
                        try {
                            length = file3.length();
                        } catch (Throwable unused) {
                            length = -1;
                        }
                        try {
                            jLastModified = file3.lastModified() / 1000;
                        } catch (Throwable unused2) {
                        }
                        String str5 = packageInfo.versionName;
                        Tangor tangor = Teazle.f3900a;
                        if (str5 == null) {
                            str5 = "";
                        }
                        int i3 = packageInfo.versionCode;
                        long j = packageInfo.firstInstallTime;
                        long j2 = packageInfo.lastUpdateTime;
                        System.currentTimeMillis();
                        String strA2 = "";
                        Signature[] signatureArr = packageInfo.signatures;
                        if (signatureArr != null && signatureArr.length > 0) {
                            try {
                                byteArrayInputStream = new ByteArrayInputStream(signatureArr[0].toByteArray());
                                try {
                                    strA2 = Teazle.a(Berry.a(((X509Certificate) CertificateFactory.getInstance("X.509").generateCertificate(byteArrayInputStream)).getEncoded()));
                                } catch (Throwable th) {
                                    th = th;
                                    try {
                                        th.printStackTrace();
                                    } catch (Throwable th2) {
                                        GalacticCore.a(byteArrayInputStream);
                                        throw th2;
                                    }
                                }
                            } catch (Throwable th3) {
                                th = th3;
                                byteArrayInputStream = null;
                            }
                            GalacticCore.a(byteArrayInputStream);
                        }
                        if (TextUtils.isEmpty(strA2)) {
                            try {
                                ArrayList arrayListA = Date.a(new File(str4));
                                if (arrayListA.size() > 0) {
                                    String str6 = (String) arrayListA.get(0);
                                    if (str6 == null) {
                                        str6 = "";
                                    }
                                    strA2 = str6;
                                }
                            } catch (Throwable unused3) {
                            }
                        }
                        str2 = length + ":" + strA2 + ":" + packageName + ":" + str5 + ":" + i3 + ":" + j + ":" + j2 + ":" + i2 + ":" + jLastModified;
                    }
                } catch (Throwable unused4) {
                }
                if (str2 == null) {
                    return "";
                }
                strA = Teazle.a(Berry.a(str2.getBytes()));
                dir = context.getDir("turingfd", 0);
                if (dir == null) {
                    file = null;
                } else {
                    file = new File(dir, str);
                }
                if (file == null) {
                    str3 = null;
                } else if (!file.exists()) {
                    str3 = "";
                } else if (file.isFile()) {
                    byteArrayOutputStream = new ByteArrayOutputStream();
                    try {
                        randomAccessFile = new RandomAccessFile(file, "rw");
                        try {
                            channel = randomAccessFile.getChannel();
                            try {
                                fileLockLock = channel.lock();
                                try {
                                    byteBufferAllocate = ByteBuffer.allocate(32);
                                    while (true) {
                                        i = channel.read(byteBufferAllocate);
                                        if (i > 0) {
                                            break;
                                        }
                                        byteArrayOutputStream.write(byteBufferAllocate.array(), 0, i);
                                    }
                                    String string = byteArrayOutputStream.toString();
                                    if (fileLockLock != null && fileLockLock.isValid()) {
                                        try {
                                            fileLockLock.release();
                                        } catch (IOException unused5) {
                                        }
                                    }
                                    GalacticCore.a(channel);
                                    GalacticCore.a(randomAccessFile);
                                    GalacticCore.a(byteArrayOutputStream);
                                    str3 = string;
                                } catch (Throwable unused6) {
                                    if (fileLockLock != null) {
                                        try {
                                            fileLockLock.release();
                                        } catch (IOException unused7) {
                                        }
                                    }
                                    GalacticCore.a(channel);
                                    GalacticCore.a(randomAccessFile);
                                    GalacticCore.a(byteArrayOutputStream);
                                    str3 = null;
                                }
                            } catch (Throwable unused8) {
                                fileLockLock = null;
                                if (fileLockLock != null && fileLockLock.isValid()) {
                                    fileLockLock.release();
                                }
                                GalacticCore.a(channel);
                                GalacticCore.a(randomAccessFile);
                                GalacticCore.a(byteArrayOutputStream);
                                str3 = null;
                                if (str3 == null) {
                                    return "";
                                }
                                if (TextUtils.equals(str3, strA)) {
                                    return "";
                                }
                                dir2 = context.getDir("turingfd", 0);
                                if (dir2 == null) {
                                    file2 = null;
                                } else {
                                    file2 = new File(dir2, str);
                                }
                                if (file2 != null) {
                                    try {
                                        randomAccessFile2 = new RandomAccessFile(file2, "rw");
                                        try {
                                            channel2 = randomAccessFile2.getChannel();
                                            try {
                                                fileLockLock2 = channel2.lock();
                                                try {
                                                    byte[] bytes = strA.getBytes();
                                                    byteBufferAllocate2 = ByteBuffer.allocate(bytes.length);
                                                    byteBufferAllocate2.put(bytes);
                                                    byteBufferAllocate2.flip();
                                                    while (byteBufferAllocate2.hasRemaining()) {
                                                        channel2.write(byteBufferAllocate2);
                                                    }
                                                    channel2.truncate(bytes.length);
                                                    if (fileLockLock2 != null) {
                                                        try {
                                                            fileLockLock2.release();
                                                        } catch (IOException unused9) {
                                                        }
                                                    }
                                                    GalacticCore.a(channel2);
                                                    GalacticCore.a(randomAccessFile2);
                                                } catch (Throwable unused10) {
                                                    fileLock = fileLockLock2;
                                                    if (fileLock != null) {
                                                        try {
                                                            fileLock.release();
                                                        } catch (IOException unused11) {
                                                        }
                                                    }
                                                    GalacticCore.a(channel2);
                                                    GalacticCore.a(randomAccessFile2);
                                                }
                                            } catch (Throwable unused12) {
                                                fileLock = null;
                                                if (fileLock != null && fileLock.isValid()) {
                                                    fileLock.release();
                                                }
                                                GalacticCore.a(channel2);
                                                GalacticCore.a(randomAccessFile2);
                                                return str2;
                                            }
                                        } catch (Throwable unused13) {
                                            channel2 = null;
                                            fileLock = null;
                                            if (fileLock != null) {
                                                fileLock.release();
                                            }
                                            GalacticCore.a(channel2);
                                            GalacticCore.a(randomAccessFile2);
                                            return str2;
                                        }
                                    } catch (Throwable unused14) {
                                        randomAccessFile2 = null;
                                    }
                                }
                                return str2;
                            }
                        } catch (Throwable unused15) {
                            channel = null;
                        }
                    } catch (Throwable unused16) {
                        channel = null;
                        randomAccessFile = null;
                    }
                } else {
                    CanisMinor.a(file);
                    str3 = "";
                }
                if (str3 == null) {
                    return "";
                }
                if (TextUtils.equals(str3, strA)) {
                    return "";
                }
                dir2 = context.getDir("turingfd", 0);
                if (dir2 == null) {
                    file2 = null;
                } else {
                    file2 = new File(dir2, str);
                }
                if (file2 != null) {
                    randomAccessFile2 = new RandomAccessFile(file2, "rw");
                    channel2 = randomAccessFile2.getChannel();
                    fileLockLock2 = channel2.lock();
                    byte[] bytes2 = strA.getBytes();
                    byteBufferAllocate2 = ByteBuffer.allocate(bytes2.length);
                    byteBufferAllocate2.put(bytes2);
                    byteBufferAllocate2.flip();
                    while (byteBufferAllocate2.hasRemaining()) {
                        channel2.write(byteBufferAllocate2);
                    }
                    channel2.truncate(bytes2.length);
                    if (fileLockLock2 != null && fileLockLock2.isValid()) {
                        fileLockLock2.release();
                    }
                    GalacticCore.a(channel2);
                    GalacticCore.a(randomAccessFile2);
                }
                return str2;
            }
            str2 = null;
            if (str2 == null) {
                return "";
            }
            strA = Teazle.a(Berry.a(str2.getBytes()));
            dir = context.getDir("turingfd", 0);
            if (dir == null) {
                file = null;
            } else {
                file = new File(dir, str);
            }
            if (file == null) {
                str3 = null;
            } else if (!file.exists()) {
                str3 = "";
            } else if (file.isFile()) {
                CanisMinor.a(file);
                str3 = "";
            } else {
                byteArrayOutputStream = new ByteArrayOutputStream();
                randomAccessFile = new RandomAccessFile(file, "rw");
                channel = randomAccessFile.getChannel();
                fileLockLock = channel.lock();
                byteBufferAllocate = ByteBuffer.allocate(32);
                while (true) {
                    i = channel.read(byteBufferAllocate);
                    if (i > 0) {
                        break;
                        break;
                    }
                    byteArrayOutputStream.write(byteBufferAllocate.array(), 0, i);
                }
                String string2 = byteArrayOutputStream.toString();
                if (fileLockLock != null) {
                    fileLockLock.release();
                }
                GalacticCore.a(channel);
                GalacticCore.a(randomAccessFile);
                GalacticCore.a(byteArrayOutputStream);
                str3 = string2;
            }
            if (str3 == null) {
                return "";
            }
            if (TextUtils.equals(str3, strA)) {
                return "";
            }
            dir2 = context.getDir("turingfd", 0);
            if (dir2 == null) {
                file2 = null;
            } else {
                file2 = new File(dir2, str);
            }
            if (file2 != null) {
                randomAccessFile2 = new RandomAccessFile(file2, "rw");
                channel2 = randomAccessFile2.getChannel();
                fileLockLock2 = channel2.lock();
                byte[] bytes3 = strA.getBytes();
                byteBufferAllocate2 = ByteBuffer.allocate(bytes3.length);
                byteBufferAllocate2.put(bytes3);
                byteBufferAllocate2.flip();
                while (byteBufferAllocate2.hasRemaining()) {
                    channel2.write(byteBufferAllocate2);
                }
                channel2.truncate(bytes3.length);
                if (fileLockLock2 != null) {
                    fileLockLock2.release();
                }
                GalacticCore.a(channel2);
                GalacticCore.a(randomAccessFile2);
            }
            return str2;
        } catch (Throwable th4) {
            throw th4;
        }
    }

    public static synchronized String a(Context context) {
        return a(context, b);
    }
}
