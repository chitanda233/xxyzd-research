package com.baidu.passbqt.permissions;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import com.baidu.passbqt.NoProguard;
import com.bykv.vk.component.ttvideo.player.C;

/* JADX INFO: loaded from: classes.dex */
public class PassPermissions implements NoProguard {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f634a = "PassPermissions";
    private static PassPermissions b;
    private PermissionsDTO c;
    private PermissionsCallback d;

    private PassPermissions() {
    }

    public static synchronized PassPermissions a() {
        if (b == null) {
            b = new PassPermissions();
        }
        return b;
    }

    public void a(PermissionsDTO permissionsDTO, final PermissionsCallback permissionsCallback) {
        if (permissionsDTO == null || permissionsDTO.f636a == null || permissionsDTO.b == null || permissionsDTO.b.length == 0 || permissionsCallback == null) {
            throw new IllegalArgumentException("params is error");
        }
        this.c = permissionsDTO;
        this.d = new PermissionsCallback() { // from class: com.baidu.passbqt.permissions.PassPermissions.1
            @Override // com.baidu.passbqt.permissions.PermissionsCallback
            public void a() {
                PassPermissions.this.d();
                permissionsCallback.a();
            }

            @Override // com.baidu.passbqt.permissions.PermissionsCallback
            public void a(int i) {
                PassPermissions.this.d();
                permissionsCallback.a(i);
            }
        };
        if (a(permissionsDTO.b)) {
            this.d.a();
            return;
        }
        Intent intent = new Intent(permissionsDTO.f636a, (Class<?>) PermissionsHelperActivity.class);
        if (permissionsDTO.f636a instanceof Activity) {
            permissionsDTO.f636a.startActivity(intent);
        } else {
            intent.setFlags(C.ENCODING_PCM_MU_LAW);
            permissionsDTO.f636a.startActivity(intent);
        }
    }

    boolean a(String... strArr) {
        for (String str : strArr) {
            if (!a(str, this.c.f636a)) {
                return false;
            }
        }
        return true;
    }

    public PermissionsDTO b() {
        return this.c;
    }

    public PermissionsCallback c() {
        return this.d;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d() {
        this.c = null;
        this.d = null;
        b = null;
    }

    public static boolean a(String str, Context context) {
        try {
            return context.checkSelfPermission(str) == 0;
        } catch (Exception unused) {
            return false;
        }
    }
}
