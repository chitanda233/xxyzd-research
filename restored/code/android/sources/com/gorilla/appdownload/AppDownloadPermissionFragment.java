package com.gorilla.appdownload;

import android.app.Fragment;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;

/* JADX INFO: loaded from: classes3.dex */
public class AppDownloadPermissionFragment extends Fragment {
    private static final int REQUEST_INSTALL_UNKNOWN_APPS = 9327;
    private IPermissionResult result;

    @Override // android.app.Fragment
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setRetainInstance(false);
    }

    public void requestInstallPermission(IPermissionResult iPermissionResult) {
        this.result = iPermissionResult;
        if (getActivity() == null) {
            notifyResult(false);
        } else {
            if (getActivity().getPackageManager().canRequestPackageInstalls()) {
                notifyResult(true);
                return;
            }
            try {
                startActivityForResult(new Intent("android.settings.MANAGE_UNKNOWN_APP_SOURCES").setData(Uri.parse("package:" + getActivity().getPackageName())), REQUEST_INSTALL_UNKNOWN_APPS);
            } catch (Exception unused) {
                notifyResult(false);
            }
        }
    }

    @Override // android.app.Fragment
    public void onActivityResult(int i, int i2, Intent intent) {
        super.onActivityResult(i, i2, intent);
        if (i != REQUEST_INSTALL_UNKNOWN_APPS) {
            return;
        }
        notifyResult(getActivity() != null ? getActivity().getPackageManager().canRequestPackageInstalls() : false);
        removeSelf();
    }

    private void notifyResult(boolean z) {
        IPermissionResult iPermissionResult = this.result;
        if (iPermissionResult != null) {
            iPermissionResult.onPermissionResult(z);
        }
    }

    private void removeSelf() {
        try {
            if (getActivity() != null) {
                getActivity().getFragmentManager().beginTransaction().remove(this).commitAllowingStateLoss();
            }
        } catch (Exception unused) {
        }
    }
}
