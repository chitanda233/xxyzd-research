package com.bytedance.ads.convert.hume.readapk;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.text.TextUtils;
import com.bytedance.ads.convert.flat.c.b;
import com.bytedance.ads.convert.flat.h.a;
import com.kuaishou.weapon.p0.t;
import java.io.DataInput;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.io.UnsupportedEncodingException;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class HumeSDK {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static String[] f1748a = new String[3];
    public static volatile boolean b = false;

    /* JADX WARN: Code duplicated, block: B:126:0x015d  */
    /* JADX WARN: Code duplicated, block: B:154:0x00f5 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:159:0x00a3 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:169:0x0166 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:184:0x00d8 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:190:0x0094 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:41:0x0069  */
    /* JADX WARN: Code duplicated, block: B:43:0x006e  */
    /* JADX WARN: Code duplicated, block: B:45:0x007c  */
    /* JADX WARN: Code duplicated, block: B:47:0x0097  */
    /* JADX WARN: Code duplicated, block: B:50:0x009c  */
    /* JADX WARN: Code duplicated, block: B:51:0x009e  */
    /* JADX WARN: Code duplicated, block: B:55:0x00a7 A[Catch: UnsupportedEncodingException -> 0x00b6, TryCatch #8 {UnsupportedEncodingException -> 0x00b6, blocks: (B:53:0x00a3, B:55:0x00a7, B:56:0x00b1), top: B:159:0x00a3 }] */
    /* JADX WARN: Code duplicated, block: B:56:0x00b1 A[Catch: UnsupportedEncodingException -> 0x00b6, TRY_LEAVE, TryCatch #8 {UnsupportedEncodingException -> 0x00b6, blocks: (B:53:0x00a3, B:55:0x00a7, B:56:0x00b1), top: B:159:0x00a3 }] */
    /* JADX WARN: Code duplicated, block: B:62:0x00bd  */
    /* JADX WARN: Code duplicated, block: B:76:0x00fb  */
    /* JADX WARN: Code duplicated, block: B:82:0x010d  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r3v0 */
    /* JADX WARN: Type inference failed for: r3v1 */
    /* JADX WARN: Type inference failed for: r3v2 */
    /* JADX WARN: Type inference failed for: r6v12, types: [boolean] */
    /* JADX WARN: Type inference failed for: r6v13 */
    /* JADX WARN: Type inference failed for: r6v14 */
    /* JADX WARN: Type inference failed for: r6v15, types: [java.io.RandomAccessFile] */
    /* JADX WARN: Type inference failed for: r6v16 */
    /* JADX WARN: Type inference failed for: r6v17 */
    /* JADX WARN: Type inference failed for: r6v18 */
    /* JADX WARN: Type inference failed for: r6v19 */
    /* JADX WARN: Type inference failed for: r6v20 */
    /* JADX WARN: Type inference failed for: r6v21 */
    /* JADX WARN: Type inference failed for: r6v22 */
    /* JADX WARN: Type inference failed for: r6v23, types: [java.io.RandomAccessFile] */
    /* JADX WARN: Type inference failed for: r6v24 */
    /* JADX WARN: Type inference failed for: r6v25 */
    /* JADX WARN: Type inference failed for: r6v26, types: [java.io.DataInput, java.io.RandomAccessFile] */
    /* JADX WARN: Type inference failed for: r6v31 */
    /* JADX WARN: Type inference failed for: r6v32 */
    /* JADX WARN: Type inference failed for: r6v33 */
    /* JADX WARN: Type inference failed for: r6v34 */
    /* JADX WARN: Type inference failed for: r6v35 */
    /* JADX WARN: Type inference failed for: r6v36 */
    /* JADX WARN: Type inference failed for: r6v37 */
    /* JADX WARN: Type inference failed for: r6v38 */
    /* JADX WARN: Type inference failed for: r6v39 */
    /* JADX WARN: Type inference failed for: r6v40 */
    /* JADX WARN: Type inference failed for: r6v41 */
    /* JADX WARN: Type inference failed for: r6v42 */
    public static void a(Context context) throws Throwable {
        String str;
        Throwable th;
        RandomAccessFile randomAccessFile;
        FileChannel channel;
        Map<Integer, ByteBuffer> mapA;
        byte[][] bArr;
        String[] strArr;
        int i;
        String[] strArr2;
        ?? IsEmpty;
        ?? randomAccessFile2;
        ?? r6;
        byte[] bArr2;
        long length;
        long j;
        int iA;
        int i2;
        ByteBuffer byteBuffer;
        int[] iArr = {-1721342362, 1903654775, 1903654776};
        ?? r3 = 0;
        str = null;
        str = null;
        str = null;
        str = null;
        str = null;
        String str2 = null;
        try {
            ApplicationInfo applicationInfo = context.getApplicationInfo();
            str = applicationInfo == null ? null : applicationInfo.sourceDir;
        } catch (Throwable unused) {
        }
        if (TextUtils.isEmpty(str)) {
            f1748a = new String[]{"", "", ""};
            return;
        }
        File file = new File(str);
        try {
            try {
                randomAccessFile = new RandomAccessFile(file, t.k);
                try {
                    channel = randomAccessFile.getChannel();
                    try {
                        mapA = b.a(b.a(channel).f1699a);
                        try {
                            try {
                                channel.close();
                            } catch (com.bytedance.ads.convert.flat.g.b | IOException unused2) {
                            }
                        } catch (IOException unused3) {
                        }
                    } catch (IOException unused4) {
                        if (channel != null) {
                            try {
                                channel.close();
                            } catch (IOException unused5) {
                            }
                        }
                        if (randomAccessFile != null) {
                            mapA = null;
                        } else {
                            mapA = null;
                        }
                        if (mapA != null) {
                            bArr = new byte[3][];
                            for (i2 = 0; i2 < 3; i2++) {
                                byteBuffer = mapA.get(Integer.valueOf(iArr[i2]));
                                if (byteBuffer != null) {
                                    byte[] bArrArray = byteBuffer.array();
                                    int iArrayOffset = byteBuffer.arrayOffset();
                                    bArr[i2] = Arrays.copyOfRange(bArrArray, byteBuffer.position() + iArrayOffset, iArrayOffset + byteBuffer.limit());
                                }
                            }
                        } else {
                            bArr = null;
                        }
                        if (bArr == null) {
                            strArr = null;
                        } else {
                            strArr = new String[3];
                            for (i = 0; i < 3; i++) {
                                try {
                                    if (bArr[i] != null) {
                                        strArr[i] = new String(bArr[i], "UTF-8");
                                    } else {
                                        strArr[i] = "";
                                    }
                                } catch (UnsupportedEncodingException e) {
                                    e.printStackTrace();
                                }
                            }
                        }
                        if (strArr == null) {
                            strArr = f1748a;
                        }
                        f1748a = strArr;
                        if (strArr.length >= 2) {
                            IsEmpty = TextUtils.isEmpty(f1748a[1]);
                            try {
                                if (IsEmpty != 0) {
                                    try {
                                        randomAccessFile2 = new RandomAccessFile(file, t.k);
                                        try {
                                            long length2 = randomAccessFile2.length();
                                            byte[] bArr3 = a.f1700a;
                                            bArr2 = new byte[bArr3.length];
                                            length = length2 - ((long) bArr3.length);
                                            randomAccessFile2.seek(length);
                                            randomAccessFile2.readFully(bArr2);
                                            if (a.a(bArr2)) {
                                                j = length - 2;
                                                randomAccessFile2.seek(j);
                                                iA = a.a((DataInput) randomAccessFile2);
                                                if (iA <= 0) {
                                                    randomAccessFile2.close();
                                                    str2 = "";
                                                    IsEmpty = randomAccessFile2;
                                                } else {
                                                    randomAccessFile2.seek(j - ((long) iA));
                                                    byte[] bArr4 = new byte[iA];
                                                    randomAccessFile2.readFully(bArr4);
                                                    String str3 = new String(bArr4, "UTF-8");
                                                    try {
                                                        randomAccessFile2.close();
                                                    } catch (IOException e2) {
                                                        e2.printStackTrace();
                                                    }
                                                    str2 = str3;
                                                    IsEmpty = randomAccessFile2;
                                                }
                                            } else {
                                                try {
                                                    randomAccessFile2.close();
                                                } catch (IOException e3) {
                                                    e3.printStackTrace();
                                                }
                                                str2 = "";
                                                IsEmpty = randomAccessFile2;
                                            }
                                        } catch (FileNotFoundException e4) {
                                            e = e4;
                                            e.printStackTrace();
                                            IsEmpty = randomAccessFile2;
                                            if (randomAccessFile2 != 0) {
                                                r6 = randomAccessFile2;
                                                try {
                                                    r6.close();
                                                    IsEmpty = r6;
                                                } catch (IOException e5) {
                                                    e5.printStackTrace();
                                                    IsEmpty = r6;
                                                }
                                            }
                                        } catch (UnsupportedEncodingException e6) {
                                            e = e6;
                                            e.printStackTrace();
                                            IsEmpty = randomAccessFile2;
                                            r6 = randomAccessFile2;
                                            if (randomAccessFile2 != 0) {
                                                r6.close();
                                                IsEmpty = r6;
                                            }
                                        } catch (IOException e7) {
                                            e = e7;
                                            e.printStackTrace();
                                            IsEmpty = randomAccessFile2;
                                            if (randomAccessFile2 != 0) {
                                                r6 = randomAccessFile2;
                                                r6.close();
                                                IsEmpty = r6;
                                            }
                                        } catch (Exception e8) {
                                            e = e8;
                                            e.printStackTrace();
                                            IsEmpty = randomAccessFile2;
                                            if (randomAccessFile2 != 0) {
                                                r6 = randomAccessFile2;
                                                r6.close();
                                                IsEmpty = r6;
                                            }
                                        } catch (Throwable th2) {
                                            th = th2;
                                            if (randomAccessFile2 != 0) {
                                                try {
                                                    randomAccessFile2.close();
                                                } catch (IOException e9) {
                                                    e9.printStackTrace();
                                                }
                                            }
                                            throw th;
                                        }
                                    } catch (FileNotFoundException e10) {
                                        e = e10;
                                        randomAccessFile2 = 0;
                                    } catch (UnsupportedEncodingException e11) {
                                        e = e11;
                                        randomAccessFile2 = 0;
                                    } catch (IOException e12) {
                                        e = e12;
                                        randomAccessFile2 = 0;
                                    } catch (Exception e13) {
                                        e = e13;
                                        randomAccessFile2 = 0;
                                    } catch (Throwable th3) {
                                        th = th3;
                                        randomAccessFile2 = r3;
                                        if (randomAccessFile2 != 0) {
                                            randomAccessFile2.close();
                                        }
                                        throw th;
                                    }
                                    String[] strArr3 = f1748a;
                                    if (str2 == null) {
                                        str2 = "";
                                    }
                                    strArr3[0] = str2;
                                }
                            } catch (Throwable th4) {
                                th = th4;
                                r3 = IsEmpty;
                            }
                        }
                        strArr2 = f1748a;
                        if (strArr2.length >= 3) {
                            return;
                        } else {
                            return;
                        }
                    } catch (Throwable th5) {
                        th = th5;
                        if (channel != null) {
                            try {
                                channel.close();
                            } catch (IOException unused6) {
                            }
                        }
                        if (randomAccessFile == null) {
                            throw th;
                        }
                        try {
                            randomAccessFile.close();
                            throw th;
                        } catch (IOException unused7) {
                            throw th;
                        }
                    }
                } catch (IOException unused8) {
                    channel = null;
                } catch (Throwable th6) {
                    th = th6;
                    channel = null;
                }
            } catch (com.bytedance.ads.convert.flat.g.b unused9) {
                mapA = null;
            }
        } catch (IOException unused10) {
            randomAccessFile = null;
            channel = null;
        } catch (Throwable th7) {
            th = th7;
            randomAccessFile = null;
            channel = null;
        }
        randomAccessFile.close();
        if (mapA != null) {
            bArr = new byte[3][];
            while (i2 < 3) {
                byteBuffer = mapA.get(Integer.valueOf(iArr[i2]));
                if (byteBuffer != null) {
                    byte[] bArrArray2 = byteBuffer.array();
                    int iArrayOffset2 = byteBuffer.arrayOffset();
                    bArr[i2] = Arrays.copyOfRange(bArrArray2, byteBuffer.position() + iArrayOffset2, iArrayOffset2 + byteBuffer.limit());
                }
            }
        } else {
            bArr = null;
        }
        if (bArr == null) {
            strArr = null;
        } else {
            strArr = new String[3];
            while (i < 3) {
                if (bArr[i] != null) {
                    strArr[i] = new String(bArr[i], "UTF-8");
                } else {
                    strArr[i] = "";
                }
            }
        }
        if (strArr == null) {
            strArr = f1748a;
        }
        f1748a = strArr;
        if (strArr.length >= 2 && TextUtils.isEmpty(strArr[0])) {
            IsEmpty = TextUtils.isEmpty(f1748a[1]);
            if (IsEmpty != 0) {
                randomAccessFile2 = new RandomAccessFile(file, t.k);
                long length3 = randomAccessFile2.length();
                byte[] bArr5 = a.f1700a;
                bArr2 = new byte[bArr5.length];
                length = length3 - ((long) bArr5.length);
                randomAccessFile2.seek(length);
                randomAccessFile2.readFully(bArr2);
                if (a.a(bArr2)) {
                    randomAccessFile2.close();
                    str2 = "";
                    IsEmpty = randomAccessFile2;
                } else {
                    j = length - 2;
                    randomAccessFile2.seek(j);
                    iA = a.a((DataInput) randomAccessFile2);
                    if (iA <= 0) {
                        randomAccessFile2.close();
                        str2 = "";
                        IsEmpty = randomAccessFile2;
                    } else {
                        randomAccessFile2.seek(j - ((long) iA));
                        byte[] bArr6 = new byte[iA];
                        randomAccessFile2.readFully(bArr6);
                        String str4 = new String(bArr6, "UTF-8");
                        randomAccessFile2.close();
                        str2 = str4;
                        IsEmpty = randomAccessFile2;
                    }
                }
                String[] strArr4 = f1748a;
                if (str2 == null) {
                    str2 = "";
                }
                strArr4[0] = str2;
            }
        }
        strArr2 = f1748a;
        if (strArr2.length >= 3 || TextUtils.isEmpty(strArr2[2])) {
            return;
        }
        int length4 = f1748a[2].length();
        if (length4 <= 4) {
            f1748a[2] = "";
        } else {
            String[] strArr5 = f1748a;
            strArr5[2] = strArr5[2].substring(2, length4 - 2);
        }
    }

    public static String getChannel(Context context) throws Throwable {
        if (!b) {
            a(context);
            b = true;
        }
        String strTrim = getExtra(context).trim();
        HashMap map = null;
        if (!TextUtils.isEmpty(strTrim)) {
            try {
                JSONObject jSONObject = new JSONObject(strTrim);
                Iterator<String> itKeys = jSONObject.keys();
                HashMap map2 = new HashMap();
                while (itKeys.hasNext()) {
                    String string = itKeys.next().toString();
                    map2.put(string, jSONObject.getString(string));
                }
                map = map2;
            } catch (JSONException e) {
                e.printStackTrace();
            } catch (Exception e2) {
                e2.printStackTrace();
            }
        }
        return (map == null || map.size() <= 0) ? "" : (String) map.get("hume_channel_id");
    }

    public static String getExtra(Context context) {
        if (!b) {
            a(context);
            b = true;
        }
        if (TextUtils.isEmpty(f1748a[0])) {
            return !TextUtils.isEmpty(f1748a[1]) ? f1748a[1] : "";
        }
        return f1748a[0];
    }
}
