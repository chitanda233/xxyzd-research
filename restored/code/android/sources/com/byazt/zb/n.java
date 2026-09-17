package com.byazt.zb;

import android.content.Context;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Build;
import android.os.Environment;
import android.util.Base64;
import com.byazt.nr.m;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kuaishou.weapon.p0.g;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Calendar;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO, 46})
public class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static int f1611a = 0;
    public static String c = "images";
    public static int da = 8;
    public static int i = 4;
    public static long n = 15360;
    public static int sl = 16;
    public static int sp = 1;
    public static int t = 32;
    public static String tt = null;
    public static int uj = 30;
    public static int ve = 1;
    public static int x = 2;

    public static boolean c(Context context, String str) {
        try {
            String[] strArr = context.getPackageManager().getPackageInfo(context.getPackageName(), 4096).requestedPermissions;
            if (strArr.length > 0) {
                for (String str2 : strArr) {
                    if (str.equals(str2)) {
                        return true;
                    }
                }
            }
        } catch (PackageManager.NameNotFoundException unused) {
        }
        return false;
    }

    public static File c() {
        try {
            File file = new File(Environment.getExternalStorageDirectory(), Environment.DIRECTORY_DCIM + File.separator + c);
            if (!file.exists()) {
                file.mkdirs();
            }
            File file2 = new File(file, "JPG_Playable_Photo.jpg");
            if (!file2.exists()) {
                file2.createNewFile();
            }
            tt = file2.getAbsolutePath();
            return file2;
        } catch (IOException unused) {
            return null;
        }
    }

    public static File c(String str) {
        try {
            File file = new File(Environment.getExternalStorageDirectory(), Environment.DIRECTORY_DCIM + File.separator + "Camera");
            if (!file.exists()) {
                file.mkdirs();
            }
            Calendar calendar = Calendar.getInstance();
            File file2 = new File(file, (calendar.get(12) + "_" + calendar.get(13) + "_" + calendar.get(14)) + "_" + str);
            if (!file2.exists()) {
                file2.createNewFile();
            }
            return file2;
        } catch (IOException unused) {
            return null;
        }
    }

    public static Bitmap tt(String str) {
        byte[] bArrDecode = Base64.decode(str, 2);
        return BitmapFactory.decodeByteArray(bArrDecode, 0, bArrDecode.length);
    }

    public static File c(String str, String str2) throws Throwable {
        FileOutputStream fileOutputStream;
        FileOutputStream fileOutputStream2 = null;
        try {
            File fileC = c(str);
            if (fileC != null && fileC.exists()) {
                byte[] bArrDecode = Base64.decode(str2, 2);
                fileOutputStream = new FileOutputStream(fileC);
                try {
                    fileOutputStream.write(bArrDecode, 0, bArrDecode.length);
                    fileOutputStream.flush();
                    fileOutputStream.close();
                    try {
                        fileOutputStream.close();
                    } catch (IOException e) {
                        m.c(e);
                    }
                    return fileC;
                } catch (IOException unused) {
                    if (fileOutputStream != null) {
                        try {
                            fileOutputStream.close();
                        } catch (IOException e2) {
                            m.c(e2);
                        }
                    }
                    return null;
                } catch (Throwable th) {
                    th = th;
                    fileOutputStream2 = fileOutputStream;
                    if (fileOutputStream2 != null) {
                        try {
                            fileOutputStream2.close();
                        } catch (IOException e3) {
                            m.c(e3);
                        }
                    }
                    throw th;
                }
            }
            return null;
        } catch (IOException unused2) {
            fileOutputStream = null;
        } catch (Throwable th2) {
            th = th2;
        }
    }

    public static boolean c(Context context, int i2) {
        boolean zC;
        boolean zC2;
        if (f1611a == 0) {
            if (Build.VERSION.SDK_INT >= 33) {
                zC = c(context, "android.permission.READ_MEDIA_IMAGES");
                zC2 = true;
            } else {
                zC = c(context, g.i);
                zC2 = c(context, g.j);
            }
            boolean zC3 = c(context, "android.permission.CAMERA");
            boolean zC4 = c(context, "android.permission.RECORD_AUDIO");
            PackageManager packageManager = context.getPackageManager();
            if (zC && zC2) {
                f1611a |= sp;
            }
            if (zC3 && packageManager.hasSystemFeature("android.hardware.camera")) {
                f1611a |= x;
            }
            if (packageManager.hasSystemFeature("android.hardware.sensor.gyroscope")) {
                f1611a |= i;
            }
            if (packageManager.hasSystemFeature("android.hardware.sensor.accelerometer")) {
                f1611a |= da;
            }
            if (packageManager.hasSystemFeature("android.hardware.sensor.compass")) {
                f1611a |= sl;
            }
            if (zC4 && packageManager.hasSystemFeature("android.hardware.microphone")) {
                f1611a |= t;
            }
        }
        return (f1611a & i2) != 0;
    }

    public static boolean c(Context context) {
        boolean z;
        boolean z2;
        if (Build.VERSION.SDK_INT >= 33) {
            z = context.checkSelfPermission("android.permission.READ_MEDIA_IMAGES") == 0;
        } else {
            z = context.checkSelfPermission(g.i) == 0;
            if (context.checkSelfPermission(g.j) != 0) {
                z2 = false;
            }
            return !z2 && z;
        }
        z2 = true;
        if (z2) {
        }
    }

    public static boolean tt(Context context, String str) {
        return context.checkSelfPermission(str) == 0;
    }
}
