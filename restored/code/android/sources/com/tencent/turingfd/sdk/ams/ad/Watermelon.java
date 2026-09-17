package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.os.Environment;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.os.StatFs;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.WindowManager;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Watermelon extends Handler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Taurus f3906a;
    public int b;
    public int c;
    public final Pomegranate d;
    public final Dorado e;
    public final int f;
    public final Warden g;

    public Watermelon(Looper looper, Dorado dorado, Taurus taurus, int i) {
        super(looper);
        this.b = 1;
        this.c = 1;
        this.g = new Warden();
        this.e = dorado;
        Pomegranate pomegranate = new Pomegranate();
        this.d = pomegranate;
        pomegranate.f = 209308;
        this.f3906a = taurus;
        this.f = i;
    }

    public final h0 a(Context context, f0 f0Var) {
        Pistachio pistachio;
        int i;
        byte[] bArrB;
        byte[] bArr;
        h0 h0VarA;
        byte[] bArrA;
        Nectarine nectarine;
        int i2 = f0Var.f3928a;
        byte[] bArrA2 = f0Var.e;
        if (bArrA2 == null) {
            bArrA2 = Sagittarius.a(f0Var.d);
        }
        int i3 = this.b;
        this.b = i3 + 1;
        if (i3 >= Integer.MAX_VALUE) {
            this.b = 1;
        }
        Cimport cimport = new Cimport();
        cimport.b = this.b;
        cimport.f3937a = i2;
        cimport.c = 0;
        cimport.g = 0;
        cimport.d = bArrA2;
        Taurus taurus = this.f3906a;
        synchronized (taurus) {
            if (taurus.b == null) {
                taurus.a();
            }
            pistachio = taurus.b;
        }
        String strA = t.a(context);
        Pomegranate pomegranate = this.d;
        pomegranate.e = pistachio.c;
        pomegranate.c = strA;
        int i4 = this.c;
        this.c = i4 + 1;
        if (i4 >= Integer.MAX_VALUE) {
            this.c = 1;
        }
        Cpublic cpublic = new Cpublic();
        ArrayList arrayList = new ArrayList();
        cpublic.d = arrayList;
        arrayList.add(cimport);
        cpublic.f3955a = this.c;
        cpublic.c = this.d;
        byte[] bArrA3 = Sagittarius.a(cpublic);
        if (bArrA3 == null) {
            h0VarA = h0.a(-13);
        } else {
            String str = cpublic.c.c;
            int i5 = cpublic.f3955a;
            int i6 = cpublic.b;
            try {
                if (bArrA3.length <= 50 || (bArrA = Cprivate.a(bArrA3)) == null || bArrA.length >= bArrA3.length) {
                    i = 1;
                } else {
                    bArrA3 = bArrA;
                    i = 0;
                }
            } catch (Exception unused) {
                i = 0;
                bArrA3 = null;
            }
            if (bArrA3 == null) {
                h0VarA = h0.a(-13);
            } else {
                byte[] bArr2 = pistachio.f3878a;
                String str2 = pistachio.c;
                this.f3906a.getClass();
                try {
                    String str3 = pistachio.b;
                    Tangor tangor = Teazle.f3900a;
                    bArrB = Cstrictfp.b(bArrA3, str3 == null ? null : str3.getBytes("utf-8"));
                } catch (UnsupportedEncodingException unused2) {
                    bArrB = null;
                }
                try {
                    Phoenix phoenix = new Phoenix();
                    phoenix.b = "UTF-8";
                    phoenix.a(2);
                    phoenix.b((byte) 10, 0);
                    if (str2 != null) {
                        phoenix.a(str2, 1);
                    }
                    if (i != 0) {
                        phoenix.a(i, 2);
                    }
                    if (str != null) {
                        phoenix.a(str, 3);
                    }
                    phoenix.a(1, 4);
                    if (i5 != 0) {
                        phoenix.a(i5, 5);
                    }
                    if (i6 != 0) {
                        phoenix.a(i6, 6);
                    }
                    phoenix.a(2);
                    phoenix.b((byte) 11, 0);
                    if (bArr2 != null) {
                        phoenix.a(1, bArr2);
                    }
                    if (bArrB != null) {
                        phoenix.a(2, bArrB);
                    }
                    byte[] bArr3 = new byte[phoenix.f3876a.position()];
                    System.arraycopy(phoenix.f3876a.array(), 0, bArr3, 0, phoenix.f3876a.position());
                    bArr = bArr3;
                } catch (Exception unused3) {
                    bArr = null;
                }
                if (bArr == null) {
                    h0VarA = h0.a(-13);
                } else {
                    Dorado dorado = this.e;
                    if (dorado == null) {
                        h0VarA = h0.a(-5);
                    } else {
                        try {
                            LeoMinor leoMinorA = dorado.a(bArr);
                            g0 g0Var = new g0();
                            g0Var.f3931a = leoMinorA.f3859a;
                            g0Var.d = leoMinorA.b;
                            h0VarA = new h0(g0Var);
                        } catch (Throwable unused4) {
                            h0VarA = h0.a(-6);
                        }
                    }
                }
            }
        }
        if (h0VarA.f3933a != 0) {
            return h0VarA;
        }
        Nucleus nucleus = (Nucleus) Sagittarius.a(h0VarA.d, new Nucleus());
        if (nucleus == null || (nectarine = nucleus.f3869a) == null) {
            return h0.a(-7);
        }
        int i7 = nectarine.b;
        if (i7 == 2) {
            this.f3906a.b();
            return h0.a(-9);
        }
        if (i7 != 0) {
            return h0.a(-12);
        }
        Mangosteen mangosteenA = a(f0Var.b, nucleus, pistachio);
        if (mangosteenA == null) {
            return h0.a(-7);
        }
        int i8 = mangosteenA.d;
        if (i8 == 0 && mangosteenA.e == 0) {
            g0 g0Var2 = new g0();
            g0Var2.f3931a = 0;
            g0Var2.d = mangosteenA.f;
            return new h0(g0Var2);
        }
        g0 g0Var3 = new g0();
        g0Var3.f3931a = -14;
        g0Var3.b = i8;
        g0Var3.c = mangosteenA.e;
        return new h0(g0Var3);
    }

    @Override // android.os.Handler
    public final void handleMessage(Message message) {
        Context context;
        int i = message.what;
        if (i == 1) {
            System.currentTimeMillis();
            Context contextA = Ccatch.a();
            if (TextUtils.isEmpty(t.a(contextA))) {
                a(contextA);
                return;
            }
            return;
        }
        if (i != 2) {
            return;
        }
        f0 f0Var = (f0) message.obj;
        Walnut walnut = f0Var.c;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        if (TextUtils.isEmpty(t.a(context))) {
            h0 h0VarA = a(context);
            if (h0VarA.f3933a != 0) {
                walnut.a(h0VarA);
                return;
            }
        }
        h0 h0VarA2 = a(context, f0Var);
        Leo leo = f0Var.g;
        int i2 = 0;
        if (leo == null) {
            leo = this.g;
        }
        while (i2 < this.f && leo.a(h0VarA2)) {
            i2++;
            h0VarA2 = a(context, f0Var);
        }
        f0Var.c.a(h0VarA2);
    }

    public final h0 a(Context context) {
        int i;
        long j;
        int iIntValue;
        Context context2;
        BufferedReader bufferedReader;
        InputStreamReader inputStreamReader;
        System.currentTimeMillis();
        String str = t.f3964a;
        AtomicReference atomicReference = Cprotected.f3954a;
        int i2 = -1;
        try {
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            DisplayMetrics displayMetrics = new DisplayMetrics();
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            i = displayMetrics.widthPixels;
        } catch (Throwable unused) {
            i = -1;
        }
        try {
            WindowManager windowManager2 = (WindowManager) context.getSystemService("window");
            DisplayMetrics displayMetrics2 = new DisplayMetrics();
            windowManager2.getDefaultDisplay().getMetrics(displayMetrics2);
            i2 = displayMetrics2.heightPixels;
        } catch (Throwable unused2) {
        }
        if (i < i2) {
            int i3 = i;
            i = i2;
            i2 = i3;
        }
        Cwhile cwhile = new Cwhile();
        cwhile.L = "";
        cwhile.d = "0";
        cwhile.e = "0";
        cwhile.f = 92;
        cwhile.g = "501191CEF186C29F";
        cwhile.h = 209308;
        cwhile.i = "" + Olive.f3871a;
        cwhile.j = 2;
        cwhile.k = 201;
        cwhile.l = false;
        try {
            cwhile.m = context.getPackageName();
        } catch (Throwable unused3) {
        }
        cwhile.o = Orange.a();
        cwhile.q = (short) 2052;
        cwhile.r = 1;
        String strA = Aquila.a("ro.product.cpu.abi2");
        Tangor tangor = Teazle.f3900a;
        cwhile.V = strA;
        StringBuilder sb = new StringBuilder("");
        long j2 = Aquila.f3819a;
        long blockSize = 0;
        try {
            if (-1 == j2) {
                try {
                    inputStreamReader = new InputStreamReader(new FileInputStream("/sys/devices/system/cpu/cpu0/cpufreq/cpuinfo_max_freq"), "UTF-8");
                    try {
                        bufferedReader = new BufferedReader(inputStreamReader);
                        try {
                            String line = bufferedReader.readLine();
                            if (line == null) {
                                inputStreamReader.close();
                                bufferedReader.close();
                                try {
                                    inputStreamReader.close();
                                    bufferedReader.close();
                                } catch (IOException unused4) {
                                }
                                j2 = 0;
                            } else {
                                String strTrim = line.trim();
                                j = strTrim.length() > 0 ? Long.parseLong(strTrim) : 0L;
                                try {
                                    inputStreamReader.close();
                                    bufferedReader.close();
                                } catch (IOException unused5) {
                                }
                                j2 = j;
                                Aquila.f3819a = j2;
                            }
                        } catch (IOException unused6) {
                            if (inputStreamReader != null) {
                                inputStreamReader.close();
                            }
                            if (bufferedReader != null) {
                                bufferedReader.close();
                            }
                            j2 = 0;
                        } catch (Throwable unused7) {
                            if (inputStreamReader != null) {
                                inputStreamReader.close();
                            }
                            if (bufferedReader != null) {
                                bufferedReader.close();
                            }
                            j2 = 0;
                        }
                    } catch (IOException unused8) {
                        bufferedReader = null;
                    } catch (Throwable unused9) {
                        bufferedReader = null;
                    }
                } catch (IOException unused10) {
                    bufferedReader = null;
                    inputStreamReader = null;
                } catch (Throwable unused11) {
                    bufferedReader = null;
                    inputStreamReader = null;
                }
            }
        } catch (IOException unused12) {
            j = 0;
        }
        String string = sb.append(j2).toString();
        if (string == null) {
            string = "";
        }
        cwhile.t = string;
        if (Aquila.b == null) {
            try {
                File[] fileArrListFiles = new File("/sys/devices/system/cpu/").listFiles(new Andromeda());
                if (fileArrListFiles != null) {
                    Aquila.b = Integer.valueOf(fileArrListFiles.length);
                    iIntValue = Aquila.b.intValue();
                }
            } catch (Throwable unused13) {
            }
            iIntValue = 1;
        } else {
            iIntValue = Aquila.b.intValue();
        }
        cwhile.u = iIntValue;
        cwhile.v = i + "*" + i2;
        try {
            File rootDirectory = Environment.getRootDirectory();
            if (!rootDirectory.exists()) {
                rootDirectory = new File("/system");
            }
            StatFs statFs = new StatFs(rootDirectory.getPath());
            long blockSize2 = ((long) statFs.getBlockSize()) * ((long) statFs.getBlockCount());
            try {
                File dataDirectory = Environment.getDataDirectory();
                if (!dataDirectory.exists()) {
                    dataDirectory = new File("/data");
                }
                StatFs statFs2 = new StatFs(dataDirectory.getPath());
                blockSize = ((long) statFs2.getBlockSize()) * ((long) statFs2.getBlockCount());
            } catch (Throwable unused14) {
            }
            blockSize += blockSize2;
        } catch (Throwable unused15) {
        }
        cwhile.x = blockSize;
        String str2 = Build.BRAND;
        if (str2 == null) {
            str2 = "";
        }
        cwhile.z = str2;
        String str3 = Build.VERSION.INCREMENTAL;
        if (str3 == null) {
            str3 = "";
        }
        cwhile.A = str3;
        String str4 = Build.VERSION.RELEASE;
        if (str4 == null) {
            str4 = "";
        }
        cwhile.B = str4;
        cwhile.P = "1.0.0";
        cwhile.Q = 1;
        cwhile.R = "";
        String strB = Aquila.b();
        if (strB == null) {
            strB = "";
        }
        cwhile.E = strB;
        cwhile.H = 0;
        cwhile.I = 0;
        String str5 = Build.DEVICE;
        if (str5 == null) {
            str5 = "";
        }
        cwhile.S = str5;
        String str6 = Build.BOARD;
        if (str6 == null) {
            str6 = "";
        }
        cwhile.T = str6;
        cwhile.U = Aquila.a("ro.build.product");
        cwhile.W = Aquila.a("ro.build.fingerprint");
        cwhile.X = Aquila.a("ro.product.locale.language");
        cwhile.Y = Aquila.a("ro.product.locale.region");
        String str7 = "";
        try {
            str7 = (String) Class.forName("android.os.Build").getMethod("getRadioVersion", null).invoke(null, null);
        } catch (Throwable unused16) {
        }
        if (str7 == null) {
            str7 = "";
        }
        cwhile.Z = str7;
        cwhile.F = Aquila.a("ro.board.platform");
        cwhile.b0 = Aquila.a("ro.mediatek.platform");
        cwhile.G = Aquila.a("ro.sf.lcd_density");
        cwhile.C = Aquila.a("ro.product.name");
        cwhile.D = Aquila.a("ro.build.version.release");
        String string2 = "";
        try {
            FileInputStream fileInputStream = new FileInputStream("/proc/version");
            BufferedReader bufferedReader2 = new BufferedReader(new InputStreamReader(fileInputStream), 8192);
            StringBuilder sb2 = new StringBuilder("");
            while (true) {
                try {
                    String line2 = bufferedReader2.readLine();
                    if (line2 == null) {
                        break;
                    }
                    sb2.append(line2);
                } catch (Throwable unused17) {
                    bufferedReader2.close();
                }
            }
            bufferedReader2.close();
            try {
                fileInputStream.close();
            } catch (Throwable unused18) {
            }
            string2 = sb2.toString();
        } catch (Throwable unused19) {
        }
        if (string2 == null) {
            string2 = "";
        }
        cwhile.c0 = string2;
        cwhile.J = false;
        cwhile.d0 = 0;
        String strA2 = Aquila.a();
        if (strA2 == null) {
            strA2 = "";
        }
        cwhile.e0 = strA2;
        e0 e0Var = new e0(1, 10001, 0);
        e0Var.d = cwhile;
        e0Var.f = new Mandarin();
        f0 f0Var = new f0(e0Var);
        synchronized (Ccatch.class) {
            context2 = Ccatch.f3917a;
        }
        h0 h0VarA = a(context2, f0Var);
        if (h0VarA.f3933a != 0) {
            return h0VarA;
        }
        Pyxis pyxisA = Sagittarius.a(h0VarA.d, f0Var.f);
        if (pyxisA instanceof Mandarin) {
            t.a(context, ((Mandarin) pyxisA).f3863a);
            return h0VarA;
        }
        return h0.a(-11);
    }

    /* JADX WARN: Code duplicated, block: B:53:0x007f  */
    public final Mangosteen a(int i, Nucleus nucleus, Pistachio pistachio) {
        Melon melon;
        ArrayList arrayList;
        Marc marc;
        Nectarine nectarine = nucleus.f3869a;
        byte[] bArr = nucleus.b;
        if (bArr != null && bArr.length > 0) {
            Taurus taurus = this.f3906a;
            taurus.getClass();
            if (pistachio == null || (marc = (Marc) Sagittarius.a(bArr, new Marc())) == null || TextUtils.isEmpty(marc.f3866a)) {
                pistachio = null;
            } else {
                Pistachio pistachio2 = new Pistachio(null, pistachio.b, marc.f3866a, marc.b);
                synchronized (taurus) {
                    taurus.b = pistachio2;
                }
                pistachio = pistachio2;
            }
            if (pistachio == null) {
                return null;
            }
        }
        byte[] bArrB = nucleus.c;
        if (bArrB == null || bArrB.length == 0) {
            return null;
        }
        int i2 = nectarine.f3868a;
        if (bArrB.length != 0) {
            if ((i2 & 2) == 0) {
                this.f3906a.getClass();
                try {
                    String str = pistachio.b;
                    Tangor tangor = Teazle.f3900a;
                    bArrB = Cstrictfp.a(bArrB, str == null ? null : str.getBytes("utf-8"));
                } catch (UnsupportedEncodingException unused) {
                    bArrB = null;
                }
            }
            if (bArrB == null || bArrB.length == 0 || ((i2 & 1) == 0 && ((bArrB = Cprivate.b(bArrB)) == null || bArrB.length == 0))) {
                bArrB = null;
            }
        } else {
            bArrB = null;
        }
        if (bArrB == null || bArrB.length == 0 || (melon = (Melon) Sagittarius.a(bArrB, new Melon())) == null || (arrayList = melon.c) == null) {
            return null;
        }
        int size = arrayList.size();
        int i3 = 0;
        while (i3 < size) {
            Object obj = arrayList.get(i3);
            i3++;
            Mangosteen mangosteen = (Mangosteen) obj;
            if (mangosteen.f3865a == i) {
                return mangosteen;
            }
        }
        return null;
    }
}
