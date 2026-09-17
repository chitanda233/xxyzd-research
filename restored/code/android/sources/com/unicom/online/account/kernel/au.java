package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Build;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import java.lang.reflect.Method;
import java.net.Inet4Address;
import java.net.Inet6Address;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.Enumeration;
import kotlin.UByte;
import org.bouncycastle.crypto.digests.SM3Digest;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class au {
    public static int b = 1;
    public static int c;

    public static String c(String str) {
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(new String(aq.b("U0hBMjU2")));
            messageDigest.update(str.getBytes());
            byte[] bArrDigest = messageDigest.digest();
            StringBuffer stringBuffer = new StringBuffer("");
            for (int i = 0; i < bArrDigest.length; i++) {
                int i2 = bArrDigest[i];
                if (i2 < 0) {
                    i2 += 256;
                }
                if (i2 < 16) {
                    stringBuffer.append("0");
                }
                stringBuffer.append(Integer.toHexString(i2));
            }
            return stringBuffer.toString();
        } catch (NoSuchAlgorithmException e) {
            as.b(e);
            return "";
        }
    }

    public static String b(int i) {
        if (i == 0) {
            return as.g.toString();
        }
        if (i == 1) {
            return as.f.toString();
        }
        if (i != 2) {
            return i != 3 ? "no info" : as.i.toString();
        }
        return as.h.toString();
    }

    public static String b(String str) {
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(new String(aq.b("TUQ1")));
            messageDigest.update(str.getBytes());
            byte[] bArrDigest = messageDigest.digest();
            StringBuffer stringBuffer = new StringBuffer("");
            for (int i = 0; i < bArrDigest.length; i++) {
                int i2 = bArrDigest[i];
                if (i2 < 0) {
                    i2 += 256;
                }
                if (i2 < 16) {
                    stringBuffer.append("0");
                }
                stringBuffer.append(Integer.toHexString(i2));
            }
            return stringBuffer.toString();
        } catch (NoSuchAlgorithmException e) {
            as.b(e);
            return "";
        }
    }

    /* JADX WARN: Code duplicated, block: B:31:0x0071  */
    /* JADX WARN: Code duplicated, block: B:40:0x00a9  */
    /* JADX WARN: Multi-variable type inference failed */
    public static int c(Context context) {
        int i;
        int simState;
        int simState2;
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getApplicationContext().getSystemService("connectivity");
            NetworkInfo activeNetworkInfo = connectivityManager.getActiveNetworkInfo();
            if (activeNetworkInfo == null || !activeNetworkInfo.isAvailable()) {
                i = -1;
            } else {
                i = 0;
                z = false;
                boolean z = false;
                i = 0;
                if (activeNetworkInfo.getType() == 1) {
                    int i2 = Build.VERSION.SDK_INT;
                    if ((i2 <= 26 || !(1 == (simState2 = ((TelephonyManager) context.getSystemService("phone")).getSimState()) || simState2 == 0)) == true) {
                        try {
                            Method declaredMethod = ConnectivityManager.class.getDeclaredMethod("getMobileDataEnabled", null);
                            declaredMethod.setAccessible(true);
                            boolean zBooleanValue = ((Boolean) declaredMethod.invoke(connectivityManager, null)).booleanValue();
                            if (!zBooleanValue) {
                                z = zBooleanValue;
                            } else if (i2 <= 26 || (1 != (simState = ((TelephonyManager) context.getSystemService("phone")).getSimState()) && simState != 0)) {
                                z = true;
                            }
                        } catch (Exception e) {
                            as.b(e);
                        }
                        if (z) {
                            i = 1;
                        } else {
                            i = 2;
                        }
                    } else {
                        i = 2;
                    }
                } else if (activeNetworkInfo.getType() == 0) {
                    as.b("Only Data");
                    String extraInfo = activeNetworkInfo.getExtraInfo();
                    if (!TextUtils.isEmpty(extraInfo)) {
                        String str = ao.b;
                        as.b("APN:" + extraInfo);
                        ao.t = extraInfo;
                        ao.r = ao.b(extraInfo);
                    }
                } else {
                    i = -1;
                }
            }
        } catch (Exception e2) {
            as.b(e2);
            i = -1;
        }
        ao.q = i;
        return i;
    }

    public static String b(Context context, String str, String str2) {
        byte[] byteArray;
        try {
            try {
                PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 64);
                byteArray = packageInfo.packageName.equals(str) ? packageInfo.signatures[0].toByteArray() : null;
            } catch (Exception e) {
                as.b(e);
            }
            try {
                return b(MessageDigest.getInstance(str2.toLowerCase()).digest(byteArray));
            } catch (Exception e2) {
                as.b(e2);
                return "";
            }
        } catch (Exception e3) {
            as.b(e3);
            return "";
        }
    }

    public static String b(Context context, String str) {
        byte[] byteArray;
        try {
            try {
                PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 64);
                byteArray = packageInfo.packageName.equals(str) ? packageInfo.signatures[0].toByteArray() : null;
            } catch (Exception e) {
                as.b(e);
            }
            try {
                SM3Digest sM3Digest = new SM3Digest();
                sM3Digest.update(byteArray, 0, byteArray.length);
                byte[] bArr = new byte[sM3Digest.getDigestSize()];
                sM3Digest.doFinal(bArr, 0);
                return b(bArr);
            } catch (Exception e2) {
                as.b(e2);
                return "";
            }
        } catch (Exception e3) {
            as.b(e3);
            return "";
        }
    }

    public static String b(byte[] bArr) {
        String str = "";
        for (int i = 0; i < bArr.length; i++) {
            if (i != 0) {
                str = str + ":";
            }
            String hexString = Integer.toHexString(bArr[i] & UByte.MAX_VALUE);
            if (hexString.length() == 1) {
                str = str + "0";
            }
            str = str + hexString;
        }
        return str;
    }

    public static ArrayList c() {
        ArrayList arrayList = new ArrayList();
        try {
            Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
            if (networkInterfaces != null) {
                while (networkInterfaces.hasMoreElements()) {
                    NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
                    String lowerCase = networkInterfaceNextElement.getName().toLowerCase();
                    if (lowerCase.startsWith("rmnet") || lowerCase.startsWith("ccmni")) {
                        Enumeration<InetAddress> inetAddresses = networkInterfaceNextElement.getInetAddresses();
                        if (inetAddresses != null) {
                            while (inetAddresses.hasMoreElements()) {
                                InetAddress inetAddressNextElement = inetAddresses.nextElement();
                                if (!inetAddressNextElement.isLoopbackAddress() && !inetAddressNextElement.isLinkLocalAddress() && !inetAddressNextElement.isMulticastAddress() && !inetAddressNextElement.isAnyLocalAddress() && ((inetAddressNextElement instanceof Inet4Address) || (inetAddressNextElement instanceof Inet6Address))) {
                                    arrayList.add(inetAddressNextElement.getHostAddress());
                                }
                            }
                        }
                    }
                }
            }
        } catch (SocketException e) {
            as.b(e);
        }
        return arrayList;
    }

    public static void b(Context context) {
        try {
        } catch (Exception unused) {
        }
    }

    public static String b() {
        try {
            return b(c());
        } catch (JSONException unused) {
            return "{\"privateIp\":\"0.0.0.0\"}";
        }
    }

    public static String b(ArrayList arrayList) throws JSONException {
        JSONObject jSONObject = new JSONObject();
        StringBuffer stringBuffer = new StringBuffer();
        StringBuffer stringBuffer2 = new StringBuffer();
        if (arrayList.size() == 0) {
            return "{\"privateIp\":\"0.0.0.0\"}";
        }
        for (int i = 0; i < arrayList.size(); i++) {
            String str = (String) arrayList.get(i);
            String strSubstring = str.substring(0, 3);
            try {
                byte[] address = InetAddress.getByName(str).getAddress();
                if (str.length() != 0) {
                    if (address.length == 4) {
                        if (!strSubstring.equals("127") && !strSubstring.equals("192")) {
                            stringBuffer.append(str).append("-");
                        }
                    } else if (!str.contains("%") && !"::1".equals(str)) {
                        stringBuffer2.append(str).append("-");
                    }
                }
            } catch (UnknownHostException e) {
                as.b(e);
                return "{\"privateIp\":\"0.0.0.0\"}";
            }
        }
        if (stringBuffer.length() != 0 && '-' == stringBuffer.charAt(stringBuffer.length() - 1)) {
            StringBuffer stringBufferDeleteCharAt = stringBuffer.deleteCharAt(stringBuffer.length() - 1);
            int iMin = Math.min(stringBuffer.length(), 5);
            for (int i2 = 0; i2 < iMin; i2++) {
                jSONObject.put("privateIp", stringBufferDeleteCharAt);
            }
        }
        if (stringBuffer2.length() != 0 && '-' == stringBuffer2.charAt(stringBuffer2.length() - 1)) {
            StringBuffer stringBufferDeleteCharAt2 = stringBuffer2.deleteCharAt(stringBuffer2.length() - 1);
            int iMin2 = Math.min(stringBuffer2.length(), 5);
            for (int i3 = 0; i3 < iMin2; i3++) {
                jSONObject.put("privateIp_v6", stringBufferDeleteCharAt2);
            }
        }
        return jSONObject.length() >= 1 ? jSONObject.toString() : "{\"privateIp\":\"0.0.0.0\"}";
    }
}
